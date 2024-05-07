using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Infrastructure.Persistance.CustomerRepository
{
    public class CustomerRepository: ICustomerRepository
    {
        public async Task<List<Customer>> Up_GetCustomers()
        {
            // Simulación de obtener clientes
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Customer 1", Description = "Description 1", Tel = "123456789", Email = "customer1@example.com", Address = "Address 1", Available = true },
                new Customer { Id = 2, Name = "Customer 2", Description = "Description 2", Tel = "987654321", Email = "customer2@example.com", Address = "Address 2", Available = true },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(customers);
        }

        public async Task<Customer> Up_GetCustomerById(int customerId)
        {
            // Simulación de obtener un cliente por su clave primaria
            Customer customer = new Customer { Id = customerId, Name = "Customer " + customerId, Description = "Description " + customerId, Tel = "555555555", Email = "customer" + customerId + "@example.com", Address = "Address " + customerId, Available = true };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(customer);
        }

        public async Task<InsertGenericResult> InsertCustomer(Customer customer)
        {
            // Simulación de inserción de un nuevo cliente
            InsertGenericResult result = new InsertGenericResult { Message = "Cliente insertado correctamente", Id = 789 }; // Se asume un valor de clave primaria ficticio (789)

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_UpdateCustomer(Customer customer)
        {
            // Simulación de actualización de un cliente
            string result = "Cliente actualizado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_DeleteCustomer(int PkCustomer)
        {
            // Simulación de eliminación de un cliente por su clave primaria
            string result = "Cliente eliminado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }
    }
}