using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Infrastructure.Persistance.StepRepository
{
    public class StepRepository : IStepRepository
    {
        public async Task<List<Step>> Up_GetSteps()
        {
            // Simulación de obtener pasos
            List<Step> steps = new List<Step>
            {
                new Step { PK = 1, FkRecipe = 501, Number = 1, Name = "Prepare Ingredients" },
                new Step { PK = 2, FkRecipe = 502, Number = 2, Name = "Cook the Pasta" },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(steps);
        }

        public async Task<Step> Up_GetStepByPK(int pk)
        {
            // Simulación de obtener un paso por su clave primaria
            Step step = new Step { PK = pk, FkRecipe = 503, Number = 3, Name = "Bake the Pizza" };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(step);
        }

        public async Task<InsertGenericResult> InsertStep(Step step)
        {
            // Simulación de inserción de un nuevo paso
            InsertGenericResult result = new InsertGenericResult { Message = "Paso insertado correctamente", Pk = 987 }; // Se asume un valor de clave primaria ficticio (987)

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_UpdateStep(Step step)
        {
            // Simulación de actualización de un paso
            string result = "Paso actualizado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_DeleteStep(int pk)
        {
            // Simulación de eliminación de un paso por su clave primaria
            string result = "Paso eliminado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }
    }
}
