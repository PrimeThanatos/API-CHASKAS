using System.Data;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Interfaces;
using API_CHASKAS.Infrastructure.Db;

namespace API_CHASKAS.Infrastructure.Persistance.PruebaRepository
{
    public class PruebaRepository
    {
        public PruebaRepository()
        {
            
        }
        private readonly IPostgresqlConnect _dbConnect = new DBPostgresqlConnect() ;

        public bool healDB()
        {
            using  var cnn = _dbConnect.GetConnection();
                     
            DataTable dt = new();

            string query  =@"
                select p.id
                from
	            staging.processes p
                limit 1
            ";
            try
            {
                dt = _dbConnect.GetData(query);

                    // Verifica si la DataTable contiene filas
                    bool isPresent = dt.Rows.Count > 0;
                    
                    // Devuelve true si hay registros, de lo contrario, false
                    return isPresent;

            }
            catch (Exception ex)
            {     
                Console.WriteLine(ex.Message);
                return false;
            }
                       
        }
        public async Task<List<Prueba>> GetUsers()
        {
            return await Task.Run(() =>
            {
                List<Prueba> pruebas = new List<Prueba>();

                pruebas.Add(new Prueba
                {
                    Name = "Kevin",
                    Available = true,
                    Email = "Kevin.tor@gmail.com",
                    PKUser = 1
                });

                pruebas.Add(new Prueba
                {
                    Name = "Kevin2",
                    Available = true,
                    Email = "Kevin2.tor@gmail.com",
                    PKUser = 2
                });

                return pruebas;
            });
        }

    }
}