using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface IArPriceRepository
    {
        public Task<List<ArPrice>> Up_GetArPricesByFKProduct(int FKProduct);
        public Task<List<ArPrice>> Up_GetArPricesByFKProductAndRangeOfDates(int FKProduct, DateTime start, DateTime end);
        public Task<ArPrice> Up_GetArPriceByPK(int ArPricePK);
        public Task<InsertGenericResult> InsertArPrice(ArPrice ArPrice);
        public Task<string> up_UpdateArPrice(ArPrice ArPrice);
        public Task<string> up_DeleteArPrice(int PkArPrice);
    }
}