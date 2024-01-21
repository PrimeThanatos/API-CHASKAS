using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Infrastructure.Persistance.CategoriesRepository
{
    public class CategoriesRepository: ICategoriesRepository
    {
         public async Task<List<Categories>> GetCategories()
        {
            // Simulación de obtener categorías
            List<Categories> categories = new List<Categories>
            {
                new Categories { Pk = 1, Description = "Category 1" },
                new Categories { Pk = 2, Description = "Category 2" },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(categories);
        }

        public async Task<Categories> GetCategoryByPK(int id)
        {
            // Simulación de obtener una categoría por su clave primaria
            Categories category = new Categories { Pk = id, Description = "Category " + id };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(category);
        }

        public async Task<InsertGenericResult> AddCategory(Categories category)
        {
            // Simulación de inserción de una nueva categoría
            InsertGenericResult result = new InsertGenericResult { Message = "Categoría insertada correctamente", Pk = 456 }; // Se asume un valor de clave primaria ficticio (456)

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_UpdateCustomer(Categories category)
        {
            // Simulación de actualización de una categoría
            string result = "Categoría actualizada correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_DeleteCustomer(int PkCustomer)
        {
            // Simulación de eliminación de una categoría por su clave primaria
            string result = "Categoría eliminada correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }
    }
}