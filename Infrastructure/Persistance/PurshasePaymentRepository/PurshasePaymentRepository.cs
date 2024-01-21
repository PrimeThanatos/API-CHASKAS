using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Infrastructure.Persistance.PurshasePaymentRepository
{
    public class PurshasePaymentRepository: IPurshasePaymentPaymentRepository
    {
        public async Task<List<PurshasePayment>> Up_GetPurshasePayments()
        {
            // Simulación de obtener pagos de compra
            List<PurshasePayment> purshasePayments = new List<PurshasePayment>
            {
                new PurshasePayment { PK = 1, FKPurshaseInvoice = 201, Total = 500 },
                new PurshasePayment { PK = 2, FKPurshaseInvoice = 202, Total = 800 },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(purshasePayments);
        }

        public async Task<PurshasePayment> Up_GetPurshasePaymentByPK(int purshasePaymentPK)
        {
            // Simulación de obtener un pago de compra por su clave primaria
            PurshasePayment purshasePayment = new PurshasePayment { PK = purshasePaymentPK, FKPurshaseInvoice = 203, Total = 1200 };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(purshasePayment);
        }

        public async Task<InsertGenericResult> InsertPurshasePayment(PurshasePayment purshasePayment)
        {
            // Simulación de inserción de un nuevo pago de compra
            InsertGenericResult result = new InsertGenericResult { Message = "Pago de compra insertado correctamente", Pk = 987 }; // Se asume un valor de clave primaria ficticio (987)

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_UpdatePurshasePayment(PurshasePayment purshasePayment)
        {
            // Simulación de actualización de un pago de compra
            string result = "Pago de compra actualizado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_DeletePurshasePayment(int pkPurshasePayment)
        {
            // Simulación de eliminación de un pago de compra por su clave primaria
            string result = "Pago de compra eliminado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }
    }
}