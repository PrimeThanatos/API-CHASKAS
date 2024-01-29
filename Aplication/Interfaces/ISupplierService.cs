using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface ISupplierService<Dto>
    {  
        Task<List<Dto>> GetSuppliers();
        Task<Dto> GetSupplierByPK(int pk);
        Task<InsertGenericResult> InsertSupplier(Dto dto);
        Task<string> UpdateSupplier(Dto dto);
        Task<string> DeleteSupplier(int pk);
         
    }
}