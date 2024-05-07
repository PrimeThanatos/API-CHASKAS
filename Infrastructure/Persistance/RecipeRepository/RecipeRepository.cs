using API_CHASKAS.Domain.Interfaces;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Infrastructure.Persistance.RecipeRepository
{
    public class RecipeRepository: IRecipeRepository
    {
        public async Task<List<Recipe>> Up_GetRecipes()
        {
            // Simulación de obtener recetas
            List<Recipe> recipes = new List<Recipe>
            {
                new Recipe { Id = 1, FKProduct = 301, Name = "Spaghetti Bolognese", PreparationTimeMinuts = 30, PKackage = "Package1" },
                new Recipe { Id = 2, FKProduct = 302, Name = "Chicken Alfredo Pasta", PreparationTimeMinuts = 45, PKackage = "Package2" },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(recipes);
        }

        public async Task<Recipe> Up_GetRecipeById(int pk)
        {
            // Simulación de obtener una receta por su clave primaria
            Recipe recipe = new Recipe { Id = pk, FKProduct = 303, Name = "Vegetarian Pizza", PreparationTimeMinuts = 25, PKackage = "Package3" };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(recipe);
        }

        public async Task<InsertGenericResult> InsertRecipe(Recipe recipe)
        {
            // Simulación de inserción de una nueva receta
            InsertGenericResult result = new InsertGenericResult { Message = "Receta insertada correctamente", Id = 654 }; // Se asume un valor de clave primaria ficticio (654)

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_UpdateRecipe(Recipe recipe)
        {
            // Simulación de actualización de una receta
            string result = "Receta actualizada correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_DeleteRecipe(int pk)
        {
            // Simulación de eliminación de una receta por su clave primaria
            string result = "Receta eliminada correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }
    }
}