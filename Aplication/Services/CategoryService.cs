using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Aplication.Services
{
  
    public class CategoryService : ICategoryService
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoryService(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository =categoriesRepository;
        }
        public Task<string> DeleteCategory(int pk)
        {
           return _categoriesRepository.up_DeleteCategory(pk);
        }

        public async Task<List<DtoCategory>> GetCategories()
        {
           var listObject =await  _categoriesRepository.GetCategories();
           return MapCategoriesToDtoList(listObject);
        }

        public async Task<DtoCategory> GetCategoryByPK(int pk)
        {
            var category = await _categoriesRepository.GetCategoryByPK(pk);
            return MapCategoryToDto(category);
        }

        public async Task<InsertGenericResult> InsertCategory(DtoCategory dto)
        {
             var entity = MapDtoToCategory(dto);
            return await _categoriesRepository.AddCategory(entity);
        }

        public async Task<string> UpdateCategory(DtoCategory dto)
        {
            var entity = MapDtoToCategory(dto);
            return await _categoriesRepository.up_UpdateCategory(entity);
        }

        // Métodos de mapeo entre Dto y entidad
        private List<DtoCategory> MapCategoriesToDtoList(List<Categories> categories)
        {
            return categories.Select(MapCategoryToDto).ToList();
        }

         private DtoCategory MapCategoryToDto(Categories category)
        {
            return new DtoCategory
            { 
                Pk = category.Pk,
                Category= category.Description
            };
        }

        private Categories MapDtoToCategory(DtoCategory dto)
        {
            return new Categories
            {
                Pk = dto.Pk,
                 Description= dto.Category
            };
        }

    }
}