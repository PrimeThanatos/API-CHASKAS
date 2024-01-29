using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface IPurchaseInvoiceRepository
    {
         
        Task<List<PurchaseInvoice>> Up_GetPurchaseInvoices();
        Task<PurchaseInvoice> Up_GetPurchaseInvoiceByPK(int purchaseInvoicePK);
        Task<InsertGenericResult> InsertPurchaseInvoice(PurchaseInvoice purchaseInvoice);
        Task<string> up_UpdatePurchaseInvoice(PurchaseInvoice purchaseInvoice);
        Task<string> up_DeletePurchaseInvoice(int pkPurchaseInvoice);
    }
}