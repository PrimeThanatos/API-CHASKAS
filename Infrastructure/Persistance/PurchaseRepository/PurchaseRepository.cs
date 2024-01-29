using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Infrastructure.Persistance.PurchaseRepository
{
    public class PurchaseRepository: IPurchaseRepository
    {
        public async Task<List<Purchase>> Up_GetPurchases()
        {
            // Simulación de obtener compras
            List<Purchase> purchases = new List<Purchase>
            {
                new Purchase { PK = 1, FKPurchaseInvoce = 101, FKProduct = 1, Measure = "Units", Quantity = 5, SubTotal = 50.0m, Taxes = 5.0m, Total = 55.0m },
                new Purchase { PK = 2, FKPurchaseInvoce = 102, FKProduct = 2, Measure = "Kg", Quantity = 2.5m, SubTotal = 30.0m, Taxes = 3.0m, Total = 33.0m },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(purchases);
        }

        public async Task<Purchase> Up_GetPurchaseByPK(int purchasePK)
        {
            // Simulación de obtener una compra por su clave primaria
            Purchase purchase = new Purchase { PK = purchasePK, FKPurchaseInvoce = 103, FKProduct = 3, Measure = "Liters", Quantity = 8, SubTotal = 80.0m, Taxes = 8.0m, Total = 88.0m };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(purchase);
        }

        public async Task<InsertGenericResult> InsertPurchase(Purchase purchase)
        {
            // Simulación de inserción de una nueva compra
            InsertGenericResult result = new InsertGenericResult { Message = "Compra insertada correctamente", Pk = 456 }; // Se asume un valor de clave primaria ficticio (456)

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_UpdatePurchase(Purchase purchase)
        {
            // Simulación de actualización de una compra
            string result = "Compra actualizada correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_DeletePurchase(int pkPurchase)
        {
            // Simulación de eliminación de una compra por su clave primaria
            string result = "Compra eliminada correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }
    }
}