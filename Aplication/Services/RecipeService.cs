using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Aplication.Services
{
    public class RecipeService : IRecipeService<DtoRecipe>
    {
        IRecipeRepository _repository;

        public RecipeService(IRecipeRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> DeleteRecipe(int Id)
        {
            return await _repository.up_DeleteRecipe(Id);
        }

        public async Task<DtoRecipe> GetRecipeById(int id)
        {
            var obj = await _repository.Up_GetRecipeById(id);
            return MapEntityToDto(obj);
        }

        public async Task<List<DtoRecipe>> GetRecipes()
        {
              var listObject =await  _repository.Up_GetRecipes();
            return MapEntitiesToDtoList(listObject);
        }

        public async Task<InsertGenericResult> InsertRecipe(DtoRecipe dto)
        {
            var obj = MapDtoToEntity(dto);
            return await _repository.InsertRecipe(obj);
        }

        public async Task<string> UpdateRecipe(DtoRecipe dto)
        {
            var obj = MapDtoToEntity(dto);
            return await _repository.up_UpdateRecipe(obj);
        }
        // Métodos de mapeo entre Dto y entidad

        private  List<DtoRecipe> MapEntitiesToDtoList(List<Recipe> dto)
        {
            return dto.Select(MapEntityToDto).ToList();
        }
        
        private  DtoRecipe MapEntityToDto(Recipe entity)
        {
            return new DtoRecipe
            { 
               
                 Id = entity.Id ,
                FKProduct = entity.FKProduct ,
                Recipe = entity.Name,     
                PreparationTimeMinuts = entity.PreparationTimeMinuts ,
                PKackage = entity.PKackage ,

            };
        }

        private Recipe MapDtoToEntity(DtoRecipe dto)
        {
            return new Recipe
            {
                Id = dto.Id ,
                FKProduct = dto.FKProduct ,
                Name = dto.Recipe,     
                PreparationTimeMinuts = dto.PreparationTimeMinuts ,
                PKackage = dto.PKackage ,
                 
            };
        }

    }
}