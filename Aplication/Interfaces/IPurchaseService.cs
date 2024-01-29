using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface IPurchaseService<Dto>
    {
        Task<List<Dto>> GetPurchases();
        Task<Dto> GetPurchaseByPK(int pk);
        Task<InsertGenericResult> InsertPurchase(Dto dto);
        Task<string> UpdatePurchase(Dto dto);
        Task<string> DeletePurchase(int pk);
    }
}