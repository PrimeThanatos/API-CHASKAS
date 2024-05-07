using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Aplication.Services
{
    public class PurchaseInvoiceInvoicesService: IPurchaseInvoicesService<DtoPurchaseInvoice>
    {
        private readonly IPurchaseInvoiceRepository _repository;
        public PurchaseInvoiceInvoicesService(IPurchaseInvoiceRepository purchaseInvoceRepository)
        {
            _repository =purchaseInvoceRepository;
        }
        public async Task<string> DeletePurchaseInvoce(int id)
        {
             return await _repository.up_DeletePurchaseInvoice(id);
        }

        public async Task<DtoPurchaseInvoice> GetPurchaseInvoceById(int id)
        {
              var obj = await _repository.Up_GetPurchaseInvoiceByPK(id);
            return MapEntityToDto(obj);
        }

        public async Task<List<DtoPurchaseInvoice>> GetPurchaseInvoces()
        {
              var listObject =await  _repository.Up_GetPurchaseInvoices();
            return MapEntitiesToDtoList(listObject);
        }

        public async Task<InsertGenericResult> InsertPurchaseInvoce(DtoPurchaseInvoice dto)
        {
            var obj = MapDtoToEntity(dto);
            return await _repository.InsertPurchaseInvoice(obj);
        }

        public async Task<string> UpdatePurchaseInvoce(DtoPurchaseInvoice dto)
        {
              var obj = MapDtoToEntity(dto);
            return await _repository.up_UpdatePurchaseInvoice(obj);
        }
        
        
        // Métodos de mapeo entre Dto y entidad

        private  List<DtoPurchaseInvoice> MapEntitiesToDtoList(List<PurchaseInvoice> dto)
        {
            return dto.Select(MapEntityToDto).ToList();
        }

        private  DtoPurchaseInvoice MapEntityToDto(PurchaseInvoice entity)
        {
            return new DtoPurchaseInvoice
            { 
                Id = entity.Id, 
                FKSupplier = entity.FKSupplier, 
                 Date = entity.Date, 
                FKPaymentMethod = entity.FKPaymentMethod, 
                 IsCredit = entity.IsCredit, 
                Total = entity.Total, 
                 Cancel = entity.Cancel, 
                Available = entity.Available, 


            };
        }

        private PurchaseInvoice MapDtoToEntity(DtoPurchaseInvoice dto)
        {
            return new PurchaseInvoice
            {
                 Id = dto.Id, 
                FKSupplier = dto.FKSupplier, 
                 Date = dto.Date, 
                FKPaymentMethod = dto.FKPaymentMethod, 
                 IsCredit = dto.IsCredit, 
                Total = dto.Total, 
                 Cancel = dto.Cancel, 
                Available = dto.Available, 
                 
            };
        }
    }
}