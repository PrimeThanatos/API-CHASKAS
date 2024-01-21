using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface ICategoriesRepository
    {
        Task<List<Categories>> GetCategories();
        Task<Categories> GetCategoryByPK(int id);
        Task<InsertGenericResult> AddCategory(Categories category);
        Task<string> up_UpdateCustomer(Categories category);
        Task<string> up_DeleteCustomer(int PkCustomer);         
    }
}