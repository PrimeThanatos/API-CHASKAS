using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Infrastructure.Persistance.ProductsRepository
{
    public class ProductsRepository: IProductsRepository
    {
        public async Task<List<Products>> Up_GetProducts()
        {
            // Simulación de obtener productos
            List<Products> products = new List<Products>
            {
                new Products { PK = 1, Name = "Product 1", Size = 10, Weight = 0.5m, PreparationTime = 15, Cost = 5.0m, SellingPrice = 10.0m, Currency = 1.0m, ExchangeRate = 1.0m, CreatedDate = DateTime.Now.AddDays(-30), ExpirationDate = DateTime.Now.AddDays(30) },
                new Products { PK = 2, Name = "Product 2", Size = 8, Weight = 0.3m, PreparationTime = 10, Cost = 3.0m, SellingPrice = 8.0m, Currency = 1.0m, ExchangeRate = 1.0m, CreatedDate = DateTime.Now.AddDays(-25), ExpirationDate = DateTime.Now.AddDays(25) },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(products);
        }

        public async Task<Products> Up_GetProductByPK(int productPK)
        {
            // Simulación de obtener un producto por su clave primaria
            Products product = new Products { PK = productPK, Name = "Product " + productPK, Size = 12, Weight = 0.7m, PreparationTime = 20, Cost = 6.0m, SellingPrice = 12.0m, Currency = 1.0m, ExchangeRate = 1.0m, CreatedDate = DateTime.Now.AddDays(-20), ExpirationDate = DateTime.Now.AddDays(20) };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(product);
        }

        public async Task<InsertGenericResult> InsertProducts(Products product)
        {
            // Simulación de inserción de un nuevo producto
            InsertGenericResult result = new InsertGenericResult { Message = "Producto insertado correctamente", Pk = 654 }; // Se asume un valor de clave primaria ficticio (654)

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_UpdateProducts(Products product)
        {
            // Simulación de actualización de un producto
            string result = "Producto actualizado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_DeleteProducts(int PkProduct)
        {
            // Simulación de eliminación de un producto por su clave primaria
            string result = "Producto eliminado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }
    }
}