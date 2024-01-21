using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Infrastructure.Persistance.ArPriceRepository
{
    public class ArPriceRepository: IArPriceRepository
    {
         private readonly IPostgresqlConnect _dbConnect;

        public ArPriceRepository(IPostgresqlConnect dbConnect)
        {
            _dbConnect = dbConnect ?? throw new ArgumentNullException(nameof(dbConnect));
        }

       public async Task<List<ArPrice>> Up_GetArPricesByFKProduct(int FKProduct)
        {
            // Simulación de obtener precios por ID de producto
            List<ArPrice> prices = new List<ArPrice>
            {
                new ArPrice { PK = 1, FKProduct = FKProduct, PriceValue = 10.5m, PurchaseDate = DateTime.Now.AddDays(-7) },
                new ArPrice { PK = 2, FKProduct = FKProduct, PriceValue = 12.0m, PurchaseDate = DateTime.Now.AddDays(-3) },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(prices);
        }

       public async Task<List<ArPrice>> Up_GetArPricesByFKProductAndRangeOfDates(int FKProduct, DateTime start, DateTime end)
        {
            // Simulación de obtener precios por ID de producto y rango de fechas
            List<ArPrice> prices = new List<ArPrice>
            {
                new ArPrice { PK = 3, FKProduct = FKProduct, PriceValue = 15.0m, PurchaseDate = DateTime.Now.AddDays(-1) },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(prices);
        }

        public async Task<ArPrice> Up_GetArPriceByPK(int ArPricePK)
        {
            // Simulación de obtener un precio por su clave primaria
            ArPrice price = new ArPrice { PK = ArPricePK, FKProduct = 5, PriceValue = 18.5m, PurchaseDate = DateTime.Now.AddDays(-2) };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(price);
        }

        public async Task<InsertGenericResult> InsertArPrice(ArPrice ArPrice)
        {
            // Simulación de inserción de un nuevo precio
            InsertGenericResult result = new InsertGenericResult { Message = "Precio insertado correctamente", Pk = 123 }; // Se asume un valor de clave primaria ficticio (123)

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_UpdateArPrice(ArPrice ArPrice)
        {
            // Simulación de actualización de un precio
            string result = "Precio actualizado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_DeleteArPrice(int PkArPrice)
        {
            // Simulación de eliminación de un precio por su clave primaria
            string result = "Precio eliminado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }


        
    }
}