using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;

namespace API_CHASKAS.Domain.Interfaces
{
    public interface ICustomerRepository
    {

        Task<List<Customer>> Up_GetCustomers();
        Task<Customer> Up_GetCustomerById(int customerid);
        Task<InsertGenericResult> InsertCustomer(Customer customer);
        Task<string> up_UpdateCustomer(Customer customer);
        Task<string> up_DeleteCustomer(int PkCustomer);
    }
}