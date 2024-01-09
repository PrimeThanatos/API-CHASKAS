using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface IPostgresqlConnect
    {
        NpgsqlConnection GetConnection();
        void CloseConnection();
        DataTable GetData(string sql);
        void SaveData(string sql);
        DataTable GetDataSP(string spName, NpgsqlParameter[] param);
        void ExecuteNonQuery(string sql);

        Task<DataTable> GetDataAsync(string sql);
        Task SaveDataAsync(string sql);
        Task<DataTable> GetDataSPAsync(string spName, NpgsqlParameter[] param);
        Task ExecuteNonQueryAsync(string sql);
        
    }
}