using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface IRecipeRepository
    {
        Task<List<Recipe>> Up_GetRecipes();
        Task<Recipe> Up_GetRecipeById(int id);
        Task<InsertGenericResult> InsertRecipe(Recipe recipe);
        Task<string> up_UpdateRecipe(Recipe recipe);
        Task<string> up_DeleteRecipe(int id);
    }
}