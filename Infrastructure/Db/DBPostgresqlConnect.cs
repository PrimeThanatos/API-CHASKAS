
using System.Data;

using API_CHASKAS.Domain.Interfaces;
using Npgsql;

namespace API_CHASKAS.Infrastructure.Db
{
    public class DBPostgresqlConnect : IPostgresqlConnect
    {
        private NpgsqlConnection conn;

        public DBPostgresqlConnect()
        {
            var host = Environment.GetEnvironmentVariable("POSTGRES_HOST") ?? "localhost";
            var port = Environment.GetEnvironmentVariable("POSTGRES_PORT") ?? "5432";
            var username = Environment.GetEnvironmentVariable("POSTGRES_USER") ?? "your_postgres_user";
            var password = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD") ?? "your_postgres_password";
            var database = Environment.GetEnvironmentVariable("POSTGRES_DB") ?? "your_database_name";

            var connectionStringBuilder = new NpgsqlConnectionStringBuilder
            {
                Host = host,
                Port = int.Parse(port),
                Username = username,
                Password = password,
                Database = database,
                // Otros parámetros opcionales, como SSLMode, Pooling, etc.
            };

            string connectionString = connectionStringBuilder.ToString();

            conn = new NpgsqlConnection(connectionString);
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public NpgsqlConnection GetConnection()
        {
            return conn;
        }

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            CloseConnection();
            return dt;
        }

        public async Task<DataTable> GetDataAsync(string sql)
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection connection = GetConnection())
            {
                await connection.OpenAsync();
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
                    }
                }
            }
            CloseConnection();
            return dt;
        }

        public void SaveData(string sql)
        {
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            CloseConnection();
        }

        public async Task SaveDataAsync(string sql)
        {
            using (NpgsqlConnection connection = GetConnection())
            {
                await connection.OpenAsync();
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    await command.ExecuteNonQueryAsync();
                }
            }
            CloseConnection();
        }

        public DataTable GetDataSP(string spName, NpgsqlParameter[] param)
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (param != null)
                    {
                        command.Parameters.AddRange(param);
                    }
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            CloseConnection();
            return dt;
        }

        public async Task<DataTable> GetDataSPAsync(string spName, NpgsqlParameter[] param)
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection connection = GetConnection())
            {
                await connection.OpenAsync();
                using (NpgsqlCommand command = new NpgsqlCommand(spName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (param != null)
                    {
                        command.Parameters.AddRange(param);
                    }
                    using (NpgsqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
                    }
                }
            }
            CloseConnection();
            return dt;
        }

        public void ExecuteNonQuery(string sql)
        {
            using (NpgsqlConnection connection = GetConnection())
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            CloseConnection();
        }

        public async Task ExecuteNonQueryAsync(string sql)
        {
            using (NpgsqlConnection connection = GetConnection())
            {
                await connection.OpenAsync();
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    await command.ExecuteNonQueryAsync();
                }
            }
            CloseConnection();
        }
    }
}
