using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Domain.Entities.Inserts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface IArPriceService
    {
        Task<List<DtoArPrice>> GetArPricesByFKProduct(int FKProduct);
        Task<List<DtoArPrice>> GetArPricesByFKProductAndRangeOfDates(int FKProduct, DateTime start, DateTime end);
        Task<DtoArPrice> GetArPriceByPK(int ArPricePK);
        Task<InsertGenericResult> InsertArPrice(DtoArPrice ArPrice);
        Task<string> UpdateArPrice(DtoArPrice ArPrice);
        Task<string> DeleteArPrice(int PkArPrice);
    }
}
