using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface IPurchasePaymentService<Dto>
    {
        Task<List<Dto>> GetPurchasePayments();
        Task<Dto> GetPurchasePaymentByPK(int pk);
        Task<InsertGenericResult> InsertPurchasePayment(Dto dto);
        Task<string> UpdatePurchasePayment(Dto dto);
        Task<string> DeletePurchasePayment(int pk);
    }
}