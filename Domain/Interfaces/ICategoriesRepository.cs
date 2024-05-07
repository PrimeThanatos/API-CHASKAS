using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface ICategoriesRepository
    {
        Task<List<Categories>> GetCategories();
        Task<Categories> GetCategoryById(int id);
        Task<InsertGenericResult> AddCategory(Categories category);
        Task<string> up_UpdateCategory(Categories category);
        Task<string> up_DeleteCategory(int PkCategory);         
    }
}