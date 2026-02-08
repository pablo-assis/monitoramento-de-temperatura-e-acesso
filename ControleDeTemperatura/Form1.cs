using MQTTnet;
using System;
using System.Buffers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeTemperatura
{

    public partial class ControleTemperatura : Form
    {
        private MQTTnet.IMqttClient _client = null!;
        DatabaseManager db = new DatabaseManager();

        public ControleTemperatura()
        {
            // O InitializeComponent deve permanecer para garantir que o Designer do VS funcione
            InitializeComponent();
            Shown += async (_, __) => await ConnectAndSubscribeAsync();
        }

        // --- Lógica MQTT ---

        private async Task ConnectAndSubscribeAsync()
        {
            // Ajustado para MqttFactory (padrão da biblioteca MQTTnet)
            var factory = new MqttClientFactory();
            _client = factory.CreateMqttClient();

            var options = new MqttClientOptionsBuilder()
                .WithClientId("WinFormsReceiver_" + Guid.NewGuid())
                .WithTcpServer("test.mosquitto.org", 1883)
                .WithCleanSession()
                .Build();

            _client.ApplicationMessageReceivedAsync += e =>
            {
                // Tratamento compatível com versões novas e antigas
                var payload = e.ApplicationMessage.Payload.ToArray();
                string json = payload.Length > 0 ? Encoding.UTF8.GetString(payload) : "{}";

                try
                {
                    var sensorData = JsonSerializer.Deserialize<SensorPayload>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    UpdateUi(sensorData, json);
                }
                catch (Exception ex)
                {
                    UpdateUi(null, $"Erro no Parse: {ex.Message} | Dados: {json}");
                }
                return Task.CompletedTask;
            };

            _client.ConnectedAsync += async _ =>
            {
                AppendLog("Conectado ao Broker.");

                var subscribeOptions = new MqttClientSubscribeOptionsBuilder()
                    .WithTopicFilter(f => f.WithTopic("pico_w/sensor"))
                    .Build();

                await _client.SubscribeAsync(subscribeOptions, System.Threading.CancellationToken.None);
                AppendLog("Assinado com sucesso.");
            };

            try
            {
                await _client.ConnectAsync(options);
            }
            catch (Exception ex)
            {
                AppendLog("Erro de conexão: " + ex.Message);
            }
        }

        private void UpdateUi(SensorPayload p, string raw)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => UpdateUi(p, raw)));
                return;
            }

            if (p != null)
            {
                // 1. Atualiza os textos com os valores
                _lblTemp.Text = $"{p.temp:F2} °C";
                _lblPres.Text = $"{p.pres} Pa";
                _lblDist.Text = $"{p.dist} mm";

                // --- LÓGICA DE CORES (VERDE = PADRÃO, VERMELHO = ALERTA) ---

                try
                {
                    db.SalvarLeitura(p, raw);
                    int hojeTemp = db.ObterEventosTemperaturaHoje();
                    int hojeDist = db.ObterEventosDistanciaHoje();
                    lblPorta.Text = hojeDist.ToString();
                    lbltemperatura.Text = hojeTemp.ToString();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("NÃO FOI POSSIVEL SALVAR O REGISTROS NO BANCO");
                    this.Close();
                }

                List<string> statusMsgs = new List<string>();
                bool temAlerta = false;

                // --- VERIFICA TEMPERATURA ---
                if (p.temp > p.temp_threshold_c)
                {
                    statusMsgs.Add($"ALERTA: TEMP ALTA (> {p.temp_threshold_c}°C)!");
                    // MODO ALERTA
                    _lblTemp.BackColor = Color.Red;
                    _lblTemp.ForeColor = Color.White;
                    temAlerta = true;
                }
                else
                {
                    // MODO NORMAL (PADRÃO DARKGREEN)
                    _lblTemp.BackColor = Color.DarkGreen;
                    _lblTemp.ForeColor = Color.White; // Texto branco para ler no verde escuro
                }

                // --- VERIFICA DISTÂNCIA (PORTA) ---
                if (p.dist > p.threshold_mm)
                {
                    statusMsgs.Add("ALERTA: PORTA ABERTA");
                    // MODO ALERTA
                    _lblDist.BackColor = Color.Red; // Ou OrangeRed para diferenciar
                    _lblDist.ForeColor = Color.White;
                    temAlerta = true;
                }
                else
                {
                    // MODO NORMAL (PADRÃO DARKGREEN)
                    _lblDist.BackColor = Color.DarkGreen;
                    _lblDist.ForeColor = Color.White;
                }

                // --- ATUALIZA O LABEL DE STATUS GERAL (lblStatus) ---
                if (lblStatus != null)
                {
                    if (temAlerta)
                    {
                        // Se tiver qualquer problema: VERMELHO
                        lblStatus.Text = string.Join("\n", statusMsgs);
                        lblStatus.BackColor = Color.Red;
                        lblStatus.ForeColor = Color.White;
                    }
                    else
                    {
                        // Se tudo estiver ok: DARKGREEN
                        lblStatus.Text = "TEMPERATURA ESTABILIZADA\nPORTA FECHADA";
                        lblStatus.BackColor = Color.DarkGreen;
                        lblStatus.ForeColor = Color.White;
                    }
                }
            }

            // Log reverso (mais novo no topo)
            string novaLinha = $"[{DateTime.Now:HH:mm:ss}] RX: {raw}{Environment.NewLine}";
            _log.Text = novaLinha + _log.Text;
        }

        private void AppendLog(string s)
        {
            if (InvokeRequired) { BeginInvoke(new Action(() => AppendLog(s))); return; }

            string novaMensagem = $"[{DateTime.Now:HH:mm:ss}] {s}{Environment.NewLine}";

            _log.Text = novaMensagem + _log.Text;
        }
    }
    public class SensorPayload
    {
        public double temp { get; set; }
        public ulong pres { get; set; }
        public uint dist { get; set; }
        public uint threshold_mm { get; set; }
        public double temp_threshold_c { get; set; }
    }
}