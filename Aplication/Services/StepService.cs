using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Aplication.Services
{
    public class StepService : IStepService<DtoStep>
    {
        IStepRepository _repository;

        public StepService(IStepRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> DeleteStep(int id)
        {
            return await _repository.up_DeleteStep(id);
        }

        public async Task<DtoStep> GetStepById(int id)
        {
             var obj = await _repository.Up_GetStepById(id);
            return MapEntityToDto(obj);
        }

        public async Task<List<DtoStep>> GetSteps()
        {
           var listObject =await  _repository.Up_GetSteps();
            return MapEntitiesToDtoList(listObject);
        }

        public async Task<InsertGenericResult> InsertStep(DtoStep dto)
        {
             var obj = MapDtoToEntity(dto);
            return await _repository.InsertStep(obj);
        }

        public async Task<string> UpdateStep(DtoStep dto)
        {
             var obj = MapDtoToEntity(dto);
            return await _repository.up_UpdateStep(obj);
        }

        // Métodos de mapeo entre Dto y entidad

        private  List<DtoStep> MapEntitiesToDtoList(List<Step> dto)
        {
            return dto.Select(MapEntityToDto).ToList();
        }
        
        private  DtoStep MapEntityToDto(Step entity)
        {
            return new DtoStep
            { 
                              
                 Id =entity.Id ,
                 FkRecipe =entity.FkRecipe ,
                 Number =entity.Number ,
                 Step =entity.Name 

            };
        }

        private Step MapDtoToEntity(DtoStep dto)
        {
            return new Step
            {
                Id = dto.Id ,
                 FkRecipe =dto.FkRecipe ,
                 Number =dto.Number ,
                 Name = dto.Step  
                 
            };
        }

    }
}