using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface IPurchaseInvoicesService<Dto>
    {
        Task<List<Dto>> GetPurchaseInvoces();
        Task<Dto> GetPurchaseInvoceByPK(int pk);
        Task<InsertGenericResult> InsertPurchaseInvoce(Dto dto);
        Task<string> UpdatePurchaseInvoce(Dto dto);
        Task<string> DeletePurchaseInvoce(int pk);
    }
}