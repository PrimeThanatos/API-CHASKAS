using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface IPurchasePaymentPaymentRepository
    {
        Task<List<PurchasePayment>> Up_GetPurchasePayments();
        Task<PurchasePayment> Up_GetPurchasePaymentByPK(int purchasePaymentPK);
        Task<InsertGenericResult> InsertPurchasePayment(PurchasePayment purchasePayment);
        Task<string> up_UpdatePurchasePayment(PurchasePayment purchasePayment);
        Task<string> up_DeletePurchasePayment(int pkPurchasePayment);
    }
}