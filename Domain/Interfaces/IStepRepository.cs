using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface IStepRepository
    {
        Task<List<Step>> Up_GetSteps();
        Task<Step> Up_GetStepById(int id);
        Task<InsertGenericResult> InsertStep(Step step);
        Task<string> up_UpdateStep(Step step);
        Task<string> up_DeleteStep(int pk);
    }
}