using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Aplication.Interfaces
{
    public interface ICustomerService<Dto>
    {

        Task<List<Dto>> GetCustomers();
        Task<Dto> GetCustomerByPK(int customerPK);
        Task<InsertGenericResult> InsertCustomer(Dto customer);
        Task<string> UpdateCustomer(Dto customer);
        Task<string> DeleteCustomer(int pk);
    }
}