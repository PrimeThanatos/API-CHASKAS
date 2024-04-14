using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface IProductsService<Dto>
    {
        Task<List<Dto>> GetProducts();
        Task<Dto> GetProductByPK(int pk);
        Task<InsertGenericResult> InsertProduct(Dto dto);
        Task<string> UpdateProduct(Dto dto);
        Task<string> DeleteProduct(int pk);
        Task<List<DtoProducts>> GetProductsByCategory(string category);

    }
}