using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface IPurchaseRepository
    {
        Task<List<Purchase>> Up_GetPurchases();
        Task<Purchase> Up_GetPurchaseByPK(int purchasePK);
        Task<InsertGenericResult> InsertPurchase(Purchase purchase);
        Task<string> up_UpdatePurchase(Purchase purchase);
        Task<string> up_DeletePurchase(int pkPurchase);
    }
}