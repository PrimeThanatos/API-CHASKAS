using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface IPurshaseRepository
    {
        Task<List<Purshase>> Up_GetPurshases();
        Task<Purshase> Up_GetPurshaseByPK(int purshasePK);
        Task<InsertGenericResult> InsertPurshase(Purshase purshase);
        Task<string> up_UpdatePurshase(Purshase purshase);
        Task<string> up_DeletePurshase(int pkPurshase);
    }
}