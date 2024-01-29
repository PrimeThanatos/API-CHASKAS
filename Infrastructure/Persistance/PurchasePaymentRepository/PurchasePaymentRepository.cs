using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Infrastructure.Persistance.PurchasePaymentRepository
{
    public class PurchasePaymentRepository: IPurchasePaymentPaymentRepository
    {
        public async Task<List<PurchasePayment>> Up_GetPurchasePayments()
        {
            // Simulación de obtener pagos de compra
            List<PurchasePayment> purchasePayments = new List<PurchasePayment>
            {
                new PurchasePayment { PK = 1, FKPurchaseInvoice = 201, Total = 500 },
                new PurchasePayment { PK = 2, FKPurchaseInvoice = 202, Total = 800 },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(purchasePayments);
        }

        public async Task<PurchasePayment> Up_GetPurchasePaymentByPK(int purchasePaymentPK)
        {
            // Simulación de obtener un pago de compra por su clave primaria
            PurchasePayment purchasePayment = new PurchasePayment { PK = purchasePaymentPK, FKPurchaseInvoice = 203, Total = 1200 };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(purchasePayment);
        }

        public async Task<InsertGenericResult> InsertPurchasePayment(PurchasePayment purchasePayment)
        {
            // Simulación de inserción de un nuevo pago de compra
            InsertGenericResult result = new InsertGenericResult { Message = "Pago de compra insertado correctamente", Pk = 987 }; // Se asume un valor de clave primaria ficticio (987)

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_UpdatePurchasePayment(PurchasePayment purchasePayment)
        {
            // Simulación de actualización de un pago de compra
            string result = "Pago de compra actualizado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_DeletePurchasePayment(int pkPurchasePayment)
        {
            // Simulación de eliminación de un pago de compra por su clave primaria
            string result = "Pago de compra eliminado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }
    }
}