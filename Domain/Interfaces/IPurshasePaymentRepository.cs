using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface IPurshasePaymentPaymentRepository
    {
        Task<List<PurshasePayment>> Up_GetPurshasePayments();
        Task<PurshasePayment> Up_GetPurshasePaymentByPK(int purshasePaymentPK);
        Task<InsertGenericResult> InsertPurshasePayment(PurshasePayment purshasePayment);
        Task<string> up_UpdatePurshasePayment(PurshasePayment purshasePayment);
        Task<string> up_DeletePurshasePayment(int pkPurshasePayment);
    }
}