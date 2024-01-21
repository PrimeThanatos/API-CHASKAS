using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface ISuppliesRepository
    {
        Task<List<Supplier>> Up_GetSuppliers();
        Task<Supplier> Up_GetSupplierByPK(int SupplierPK);
        Task<InsertGenericResult> InsertSupplier(Supplier Supplier);
        Task<string> up_UpdateSupplier(Supplier Supplier);
        Task<string> up_DeleteSupplier(int PkSupplier);
    }
}