using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface IStepService<Dto>
    {
        Task<List<Dto>> GetSteps();
        Task<Dto> GetStepByPK(int pk);
        Task<InsertGenericResult> InsertStep(Dto dto);
        Task<string> UpdateStep(Dto dto);
        Task<string> DeleteStep(int pk);
    }
}