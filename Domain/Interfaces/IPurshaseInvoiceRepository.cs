using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface IPurshaseInvoiceRepository
    {
         
        Task<List<PurshaseInvoice>> Up_GetPurshaseInvoices();
        Task<PurshaseInvoice> Up_GetPurshaseInvoiceByPK(int purshaseInvoicePK);
        Task<InsertGenericResult> InsertPurshaseInvoice(PurshaseInvoice purshaseInvoice);
        Task<string> up_UpdatePurshaseInvoice(PurshaseInvoice purshaseInvoice);
        Task<string> up_DeletePurshaseInvoice(int pkPurshaseInvoice);
    }
}