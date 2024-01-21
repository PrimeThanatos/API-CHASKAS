using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface ISaleInvoiceRepository
    {
         
        Task<List<SaleInvoice>> Up_GetSaleInvoices();
        Task<SaleInvoice> Up_GetSaleInvoiceByPK(int pk);
        Task<InsertGenericResult> InsertSaleInvoice(SaleInvoice saleInvoice);
        Task<string> up_UpdateSaleInvoice(SaleInvoice SaleInvoice);
        Task<string> up_DeleteSaleInvoice(int pk);
    }
}