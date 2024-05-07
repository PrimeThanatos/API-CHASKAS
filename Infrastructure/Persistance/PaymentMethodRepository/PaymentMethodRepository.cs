using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Infrastructure.Persistance.PaymentMethodRepository
{
    public class PaymentMethodRepository: IPaymentMethodRepository
    {
        public async Task<List<PaymentMethod>> Up_GetPaymentMethods()
        {
            // Simulación de obtener métodos de pago
            List<PaymentMethod> paymentMethods = new List<PaymentMethod>
            {
                new PaymentMethod { Id = 1, Name = "PaymentMethod 1" },
                new PaymentMethod { Id = 2, Name = "PaymentMethod 2" },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(paymentMethods);
        }

        public async Task<PaymentMethod> Up_GetPaymentMethodByPK(int paymentMethodPK)
        {
            // Simulación de obtener un método de pago por su clave primaria
            PaymentMethod paymentMethod = new PaymentMethod { Id = paymentMethodPK, Name = "PaymentMethod " + paymentMethodPK };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(paymentMethod);
        }

        public async Task<InsertGenericResult> InsertPaymentMethod(PaymentMethod paymentMethod)
        {
            // Simulación de inserción de un nuevo método de pago
            InsertGenericResult result = new InsertGenericResult { Message = "Método de pago insertado correctamente", Id = 987 }; // Se asume un valor de clave primaria ficticio (987)

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_UpdatePaymentMethod(PaymentMethod paymentMethod)
        {
            // Simulación de actualización de un método de pago
            string result = "Método de pago actualizado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_DeletePaymentMethod(int pkPaymentMethod)
        {
            // Simulación de eliminación de un método de pago por su clave primaria
            string result = "Método de pago eliminado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }
    }
}