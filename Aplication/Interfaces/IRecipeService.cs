using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface IRecipeService<Dto>
    {
        Task<List<Dto>> GetRecipes();
        Task<Dto> GetRecipeById(int id);
        Task<InsertGenericResult> InsertRecipe(Dto dto);
        Task<string> UpdateRecipe(Dto dto);
        Task<string> DeleteRecipe(int id);
    }
}