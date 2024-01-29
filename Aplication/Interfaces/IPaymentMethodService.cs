using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface IPaymentMethodService<Dto>
    {
        Task<List<Dto>> GetPaymentMethods();
        Task<Dto> GetPaymentMethodByPK(int pk);
        Task<InsertGenericResult> InsertPaymentMethod(Dto dto);
        Task<string> UpdatePaymentMethod(Dto dto);
        Task<string> DeletePaymentMethod(int pk);
    }
}