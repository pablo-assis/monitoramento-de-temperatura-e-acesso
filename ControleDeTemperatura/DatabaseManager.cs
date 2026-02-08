using Microsoft.Data.Sqlite;
using System;

namespace ControleDeTemperatura
{
    internal class DatabaseManager
    {
        private readonly string _connectionString = "Data Source=sensores_data.db";

        public DatabaseManager()
        {
            InicializarBanco();
        }

        private void InicializarBanco()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();

                // O segredo está no 'IF NOT EXISTS'
                // INTEGER no SQLite suporta até 64-bit (perfeito para ulong/uint)
                command.CommandText = @"
                CREATE TABLE IF NOT EXISTS HistoricoSensores (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    data_hora DATETIME DEFAULT CURRENT_TIMESTAMP,
                    temperatura REAL,
                    pressao INTEGER, 
                    distancia INTEGER,
                    threshold_dist INTEGER,
                    threshold_temp REAL,
                    raw_string TEXT
                );";
                command.ExecuteNonQuery();
            }
        }

        public void SalvarLeitura(SensorPayload p, string raw)
        {
            try
            {
                using (var connection = new SqliteConnection(_connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = @"
                    INSERT INTO HistoricoSensores 
                    (temperatura, pressao, distancia, threshold_dist, threshold_temp, raw_string)
                    VALUES ($temp, $pres, $dist, $t_dist, $t_temp, $raw);";

                    // Mapeamento correto dos tipos da sua classe
                    command.Parameters.AddWithValue("$temp", p.temp);
                    command.Parameters.AddWithValue("$pres", (long)p.pres); // Cast para long para o SQLite
                    command.Parameters.AddWithValue("$dist", p.dist);
                    command.Parameters.AddWithValue("$t_dist", p.threshold_mm);
                    command.Parameters.AddWithValue("$t_temp", p.temp_threshold_c);
                    command.Parameters.AddWithValue("$raw", raw ?? "");

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Se o banco falhar, a UI não deve travar
                System.Diagnostics.Debug.WriteLine($"Erro SQLite: {ex.Message}");
            }
        }
        public int ObterEventosTemperaturaHoje()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();

                command.CommandText = @"
            SELECT COUNT(*) 
            FROM (
                SELECT temperatura, threshold_temp, data_hora,
                       LAG(temperatura) OVER (ORDER BY id) as temp_anterior,
                       LAG(threshold_temp) OVER (ORDER BY id) as threshold_anterior
                FROM HistoricoSensores
                WHERE DATE(data_hora) = DATE('now', 'localtime')
            ) AS Subquery
            WHERE temperatura > threshold_temp 
              AND (temp_anterior <= threshold_anterior OR temp_anterior IS NULL);";

                var result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }
        public int ObterEventosDistanciaHoje()
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();

                command.CommandText = @"
            SELECT COUNT(*) 
            FROM (
                SELECT distancia, threshold_dist, data_hora,
                       LAG(distancia) OVER (ORDER BY id) as dist_anterior,
                       LAG(threshold_dist) OVER (ORDER BY id) as threshold_anterior
                FROM HistoricoSensores
                WHERE DATE(data_hora) = DATE('now', 'localtime')
            ) AS Subquery
            WHERE distancia > threshold_dist 
              AND (dist_anterior <= threshold_anterior OR dist_anterior IS NULL);";

                var result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }
    }
}
