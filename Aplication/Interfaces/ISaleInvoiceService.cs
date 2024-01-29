using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface ISaleInvoiceService<Dto>
    {
        Task<List<Dto>> GetSaleInvoces();
        Task<Dto> GetSaleInvoceByPK(int pk);
        Task<InsertGenericResult> InsertSaleInvoce(Dto dto);
        Task<string> UpdateSaleInvoce(Dto dto);
        Task<string> DeleteSaleInvoce(int pk);
         
    }
}