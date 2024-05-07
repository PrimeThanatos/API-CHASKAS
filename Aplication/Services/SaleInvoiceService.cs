using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Aplication.Services
{
    public class SaleInvoiceService : ISaleInvoiceService<DtoSaleInvoice>
    {
        ISaleInvoiceRepository _repository;

        public SaleInvoiceService(ISaleInvoiceRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> DeleteSaleInvoce(int pk)
        {
            return await _repository.up_DeleteSaleInvoice(pk);
        }

        public async Task<DtoSaleInvoice> GetSaleInvoceByPK(int pk)
        {
             var obj = await _repository.Up_GetSaleInvoiceByPK(pk);
            return MapEntityToDto(obj);
        }

        public async Task<List<DtoSaleInvoice>> GetSaleInvoces()
        {
              var listObject =await  _repository.Up_GetSaleInvoices();
            return MapEntitiesToDtoList(listObject);
        }

        public async Task<InsertGenericResult> InsertSaleInvoce(DtoSaleInvoice dto)
        {
             var obj = MapDtoToEntity(dto);
            return await _repository.InsertSaleInvoice(obj);
        }

        public async Task<string> UpdateSaleInvoce(DtoSaleInvoice dto)
        {
           var obj = MapDtoToEntity(dto);
            return await _repository.up_UpdateSaleInvoice(obj);
        }
         // Métodos de mapeo entre Dto y entidad

        private  List<DtoSaleInvoice> MapEntitiesToDtoList(List<SaleInvoice> dto)
        {
            return dto.Select(MapEntityToDto).ToList();
        }
        
        private  DtoSaleInvoice MapEntityToDto(SaleInvoice entity)
        {
            return new DtoSaleInvoice
            { 
               
               
                Id = entity.Id,
                FKCustomer = entity.FKCustomer ,
                FKPaymentMethod = entity.FKPaymentMethod ,
                 Date = entity.Date ,
                Total = entity.Total ,
                 Cancel = entity.Cancel ,
                Available = entity.Available 

            };
        }

        private SaleInvoice MapDtoToEntity(DtoSaleInvoice dto)
        {
            return new SaleInvoice
            {
                Id = dto.Id ,
                FKCustomer = dto.FKCustomer ,
                FKPaymentMethod = dto.FKPaymentMethod ,
                 Date = dto.Date ,
                Total = dto.Total ,
                 Cancel = dto.Cancel ,
                Available = dto.Available 
                 
            };
        }

    }
}