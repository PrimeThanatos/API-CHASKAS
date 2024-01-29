using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Aplication.Services
{
    public class PurchasePaymentService : IPurchasePaymentService<DtoPurchasePayment>
    {
        private readonly IPurchasePaymentPaymentRepository _repository;

        public PurchasePaymentService(IPurchasePaymentPaymentRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> DeletePurchasePayment(int pk)
        {
            return await _repository.up_DeletePurchasePayment(pk);
        }

        public async Task<DtoPurchasePayment> GetPurchasePaymentByPK(int pk)
        {
              var obj = await _repository.Up_GetPurchasePaymentByPK(pk);
            return MapEntityToDto(obj);
        }

        public async Task<List<DtoPurchasePayment>> GetPurchasePayments()
        {
             var listObject =await  _repository.Up_GetPurchasePayments();
            return MapEntitiesToDtoList(listObject);
        }

        public async Task<InsertGenericResult> InsertPurchasePayment(DtoPurchasePayment dto)
        {
           var obj = MapDtoToEntity(dto);
            return await _repository.InsertPurchasePayment(obj);
        }

        public async Task<string> UpdatePurchasePayment(DtoPurchasePayment dto)
        {
            var obj = MapDtoToEntity(dto);
            return await _repository.up_UpdatePurchasePayment(obj);
        }

        // Métodos de mapeo entre Dto y entidad

        private  List<DtoPurchasePayment> MapEntitiesToDtoList(List<PurchasePayment> dto)
        {
            return dto.Select(MapEntityToDto).ToList();
        }
        
        private  DtoPurchasePayment MapEntityToDto(PurchasePayment entity)
        {
            return new DtoPurchasePayment
            { 
                PK = entity.PK,
                FKPurchaseInvoice = entity.FKPurchaseInvoice,
                Total = entity.Total
            };
        }

        private PurchasePayment MapDtoToEntity(DtoPurchasePayment dto)
        {
            return new PurchasePayment
            {
                 PK = dto.PK,
                FKPurchaseInvoice = dto.FKPurchaseInvoice,
                Total = dto.Total
                 
            };
        }

    }
}