using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface IStepService<Dto>
    {
        Task<List<Dto>> GetSteps();
        Task<Dto> GetStepById(int id);
        Task<InsertGenericResult> InsertStep(Dto dto);
        Task<string> UpdateStep(Dto dto);
        Task<string> DeleteStep(int id);
    }
}