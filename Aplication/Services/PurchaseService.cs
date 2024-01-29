using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Aplication.Services
{
    public class PurchasesService : IPurchaseService<DtoPurchase>
    {
        private readonly IPurchaseRepository _repository;
        public PurchasesService(IPurchaseRepository purchaseRepository)
        {
            _repository =purchaseRepository;
        }
        public async Task<string> DeletePurchase(int pk)
        {
             return await _repository.up_DeletePurchase(pk);
        }

        public async Task<DtoPurchase> GetPurchaseByPK(int pk)
        {
              var obj = await _repository.Up_GetPurchaseByPK(pk);
            return MapEntityToDto(obj);
        }

        public async Task<List<DtoPurchase>> GetPurchases()
        {
              var listObject =await  _repository.Up_GetPurchases();
            return MapEntitiesToDtoList(listObject);
        }

        public async Task<InsertGenericResult> InsertPurchase(DtoPurchase dto)
        {
            var obj = MapDtoToEntity(dto);
            return await _repository.InsertPurchase(obj);
        }

        public async Task<string> UpdatePurchase(DtoPurchase dto)
        {
              var obj = MapDtoToEntity(dto);
            return await _repository.up_UpdatePurchase(obj);
        }
        
        
        // Métodos de mapeo entre Dto y entidad

        private  List<DtoPurchase> MapEntitiesToDtoList(List<Purchase> dto)
        {
            return dto.Select(MapEntityToDto).ToList();
        }

        private  DtoPurchase MapEntityToDto(Purchase entity)
        {
            return new DtoPurchase
            { 
               PK= entity.PK ,
                FKPurchaseInvoce= entity.FKPurchaseInvoce ,
                FKProduct= entity.FKProduct ,
                Measure = entity.Measure  ,
                Quantity= entity.Quantity ,
                SubTotal= entity.SubTotal ,
                Taxes= entity.Taxes ,
                Total= entity.Total ,


            };
        }

        private Purchase MapDtoToEntity(DtoPurchase dto)
        {
            return new Purchase
            {
                 PK= dto.PK ,
                FKPurchaseInvoce= dto.FKPurchaseInvoce ,
                FKProduct= dto.FKProduct ,
                Measure = dto.Measure  ,
                Quantity= dto.Quantity ,
                SubTotal= dto.SubTotal ,
                Taxes= dto.Taxes ,
                Total= dto.Total ,
                 
            };
        }

    }
}