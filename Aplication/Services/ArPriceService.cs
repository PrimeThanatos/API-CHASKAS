using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Aplication.Services
{
    public class ArPriceService : IArPriceService
    {
        private readonly IArPriceRepository _arPriceRepository;

        public ArPriceService(IArPriceRepository arPriceRepository)
        {
            _arPriceRepository = arPriceRepository;
        }

        public async Task<List<DtoArPrice>> GetArPricesByFKProduct(int FKProduct)
        {
            var arPrices = await _arPriceRepository.Up_GetArPricesByFKProduct(FKProduct);
            return MapArPricesToDtoList(arPrices);
        }

        public async Task<List<DtoArPrice>> GetArPricesByFKProductAndRangeOfDates(int FKProduct, DateTime start, DateTime end)
        {
            var arPrices = await _arPriceRepository.Up_GetArPricesByFKProductAndRangeOfDates(FKProduct, start, end);
            return MapArPricesToDtoList(arPrices);
        }

        public async Task<DtoArPrice> GetArPriceByPK(int ArPricePK)
        {
            var arPrice = await _arPriceRepository.Up_GetArPriceByPK(ArPricePK);
            return MapArPriceToDto(arPrice);
        }

        public async Task<InsertGenericResult> InsertArPrice(DtoArPrice ArPrice)
        {
            var entity = MapDtoToArPrice(ArPrice);
            return await _arPriceRepository.InsertArPrice(entity);
        }

        public async Task<string> UpdateArPrice(DtoArPrice ArPrice)
        {
            var entity = MapDtoToArPrice(ArPrice);
            return await _arPriceRepository.up_UpdateArPrice(entity);
        }

        public async Task<string> DeleteArPrice(int PkArPrice)
        {
            return await _arPriceRepository.up_DeleteArPrice(PkArPrice);
        }

        // Métodos de mapeo entre Dto y entidad
        private List<DtoArPrice> MapArPricesToDtoList(List<ArPrice> arPrices)
        {
            return arPrices.Select(MapArPriceToDto).ToList();
        }

        private DtoArPrice MapArPriceToDto(ArPrice arPrice)
        {
            return new DtoArPrice
            {
                PK = arPrice.PK,
                FKProduct = arPrice.FKProduct,
                PriceValue = arPrice.PriceValue,
                Currency = arPrice.Currency,
                ExchangeRate = arPrice.ExchangeRate,
                PurchaseDate = arPrice.PurchaseDate
            };
        }

        private ArPrice MapDtoToArPrice(DtoArPrice dto)
        {
            return new ArPrice
            {
                PK = dto.PK,
                FKProduct = dto.FKProduct,
                PriceValue = dto.PriceValue,
                Currency = dto.Currency,
                ExchangeRate = dto.ExchangeRate,
                PurchaseDate = dto.PurchaseDate
            };
        }
    
    }
}
