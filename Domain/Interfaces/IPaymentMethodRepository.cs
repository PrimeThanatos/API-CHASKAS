using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface IPaymentMethodRepository
    {
        Task<List<PaymentMethod>> Up_GetPaymentMethods();
        Task<PaymentMethod> Up_GetPaymentMethodByPK(int paymentMethodPK);
        Task<InsertGenericResult> InsertPaymentMethod(PaymentMethod paymentMethod);
        Task<string> up_UpdatePaymentMethod(PaymentMethod paymentMethod);
        Task<string> up_DeletePaymentMethod(int pkPaymentMethod);
    }
}