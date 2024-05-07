using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface ICategoryService
    {
          Task<List<DtoCategory>> GetCategories();
          Task<DtoCategory> GetCategoryById(int id);
          Task<InsertGenericResult> InsertCategory(DtoCategory dto);
            Task<string> UpdateCategory(DtoCategory dto);
            Task<string> DeleteCategory(int id);
    }
}