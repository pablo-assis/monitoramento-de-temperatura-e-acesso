using System;
using System.Windows.Forms;

namespace ControleDeTemperatura
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread] // <--- CORREÇÃO: O atributo fica AQUI, no método Main
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Aqui iniciamos o formulário.
            // Se o seu formulário principal tiver outro nome (ex: ControleTemperatura), mude abaixo.
            Application.Run(new ControleTemperatura());
        }
    }

    // A definição do Form fica separada (sem o atributo STAThread)
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.Text = "Teste Simples";
            Button btn = new Button { Text = "Clique Me", Left = 50, Top = 50 };
            btn.Click += (s, e) => MessageBox.Show("A janela está funcionando!");
            Controls.Add(btn);
        }
    }
}