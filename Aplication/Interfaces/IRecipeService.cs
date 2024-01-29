using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface IRecipeService<Dto>
    {
        Task<List<Dto>> GetRecipes();
        Task<Dto> GetRecipeByPK(int pk);
        Task<InsertGenericResult> InsertRecipe(Dto dto);
        Task<string> UpdateRecipe(Dto dto);
        Task<string> DeleteRecipe(int pk);
    }
}