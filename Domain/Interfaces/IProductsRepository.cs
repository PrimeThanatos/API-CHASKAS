using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface IProductsRepository
    {
        Task<List<Products>> Up_GetProducts();
        Task<Products> Up_GetProductByPK(int ProductPK);
        Task<InsertGenericResult> InsertProducts(Products Product);
        Task<string> up_UpdateProducts(Products Product);
        Task<string> up_DeleteProducts(int PkProduct);
        Task<List<Products>> Up_GetProductsByCategory(string category);

    }
}