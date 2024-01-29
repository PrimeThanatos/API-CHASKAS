using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Aplication.Services
{
    public class PaymentMethodService : IPaymentMethodService<DtoPaymentMethod>
    {
        private readonly IPaymentMethodRepository _repository;
        public PaymentMethodService(IPaymentMethodRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> DeletePaymentMethod(int pk)
        {
            return await _repository.up_DeletePaymentMethod(pk);
        }

        public async Task<DtoPaymentMethod> GetPaymentMethodByPK(int pk)
        {
            var obj = await _repository.Up_GetPaymentMethodByPK(pk);
            return MapEntityToDto(obj);

        }

        public async Task<List<DtoPaymentMethod>> GetPaymentMethods()
        {
              var listObject =await  _repository.Up_GetPaymentMethods();
            return MapEntitiesToDtoList(listObject);
        }

        public async Task<InsertGenericResult> InsertPaymentMethod(DtoPaymentMethod dto)
        {
               var obj = MapDtoToEntity(dto);
            return await _repository.InsertPaymentMethod(obj);
        }

        public async Task<string> UpdatePaymentMethod(DtoPaymentMethod dto)
        {
             var obj = MapDtoToEntity(dto);
            return await _repository.up_UpdatePaymentMethod(obj);
        }

          // Métodos de mapeo entre Dto y entidad

        private  List<DtoPaymentMethod> MapEntitiesToDtoList(List<PaymentMethod> dto)
        {
            return dto.Select(MapEntityToDto).ToList();
        }

        private  DtoPaymentMethod MapEntityToDto(PaymentMethod entity)
        {
            return new DtoPaymentMethod
            { 
                PK = entity.PK,
                Payment = entity.Name  ,                            
            };
        }

        private PaymentMethod MapDtoToEntity(DtoPaymentMethod dto)
        {
            return new PaymentMethod
            {
                 PK = dto.PK,
                Name = dto.Payment  ,
                 
            };
        }

    }
}