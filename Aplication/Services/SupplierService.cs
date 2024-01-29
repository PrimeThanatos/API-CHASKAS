using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Aplication.Services
{
    public class SupplierService : ISupplierService<DtoSupplier>
    {
        ISuppliesRepository _repository;

        public SupplierService(ISuppliesRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> DeleteSupplier(int pk)
        {
            return await _repository.up_DeleteSupplier(pk);
        }

        public async Task<DtoSupplier> GetSupplierByPK(int pk)
        {
              var obj = await _repository.Up_GetSupplierByPK(pk);
            return MapEntityToDto(obj);
        }

        public async Task<List<DtoSupplier>> GetSuppliers()
        {
              var listObject =await  _repository.Up_GetSuppliers();
            return MapEntitiesToDtoList(listObject);
        }

        public async Task<InsertGenericResult> InsertSupplier(DtoSupplier dto)
        {
           var obj = MapDtoToEntity(dto);
            return await _repository.InsertSupplier(obj);
        }

        public async Task<string> UpdateSupplier(DtoSupplier dto)
        {
            var obj = MapDtoToEntity(dto);
            return await _repository.up_UpdateSupplier(obj);
        }

         // Métodos de mapeo entre Dto y entidad

        private  List<DtoSupplier> MapEntitiesToDtoList(List<Supplier> dto)
        {
            return dto.Select(MapEntityToDto).ToList();
        }
        
        private  DtoSupplier MapEntityToDto(Supplier entity)
        {
            return new DtoSupplier
            { 
                              
                 PK = entity.PK,
                 Name = entity.Name,
                 Description = entity.Description,
                  RFC = entity.RFC,
                 CP = entity.CP,
                 Adress = entity.Adress,
                CreditDays = entity.CreditDays,
                Available = entity.Available

            };
        }

        private Supplier MapDtoToEntity(DtoSupplier dto)
        {
            return new Supplier
            {
                PK = dto.PK,
                 Name = dto.Name,
                 Description = dto.Description,
                  RFC = dto.RFC,
                 CP = dto.CP,
                 Adress = dto.Adress,
                CreditDays = dto.CreditDays,
                Available = dto.Available 
                 
            };
        }

    }
}