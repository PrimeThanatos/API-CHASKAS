using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Aplication.Services
{
    public class CustomerService: ICustomerService<DtoCustomer>
    {
         private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository =repository;
        }
        public async Task<string> DeleteCustomer(int pk)
        {
           return await _repository.up_DeleteCustomer(pk);
        }

        public async Task<DtoCustomer> GetCustomerByPK(int pk)
        {
            var obj = await _repository.Up_GetCustomerByPK(pk);
            return MapEntityToDto(obj);

        }

        public async Task<List<DtoCustomer>> GetCustomers()
        {
            var listObject =await  _repository.Up_GetCustomers();
            return MapEntitiesToDtoList(listObject);
        }

        public async Task<InsertGenericResult> InsertCustomer(DtoCustomer dto)
        {
            var obj = MapDtoToEntity(dto);
            return await _repository.InsertCustomer(obj);
        }

        public async Task<string> UpdateCustomer(DtoCustomer dto)
        {
             var obj = MapDtoToEntity(dto);
            return await _repository.up_UpdateCustomer(obj);
        }
        // Métodos de mapeo entre Dto y entidad

        private List<DtoCustomer> MapEntitiesToDtoList(List<Customer> dto)
        {
            return dto.Select(MapEntityToDto).ToList();
        }

        private DtoCustomer MapEntityToDto(Customer entity)
        {
            return new DtoCustomer
            { 
                PK = entity.PK,
                Name = entity.Name  ,
                 Description = entity.Description  ,
                 Tel = entity.Tel  ,
                 Email = entity.Email  ,
                 Address = entity.Address  ,
                Available = entity.Available  ,               
            };
        }

        private Customer MapDtoToEntity(DtoCustomer dto)
        {
            return new Customer
            {
                 PK = dto.PK,
                Name = dto.Name  ,
                 Description = dto.Description  ,
                 Tel = dto.Tel  ,
                 Email = dto.Email  ,
                 Address = dto.Address  ,
                Available = dto.Available  ,   
            };
        }
    }
}