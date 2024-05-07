using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface IPurchaseService<Dto>
    {
        Task<List<Dto>> GetPurchases();
        Task<Dto> GetPurchaseById(int id);
        Task<InsertGenericResult> InsertPurchase(Dto dto);
        Task<string> UpdatePurchase(Dto dto);
        Task<string> DeletePurchase(int id);
    }
}