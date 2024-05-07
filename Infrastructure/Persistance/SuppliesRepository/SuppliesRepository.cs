using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Infrastructure.Persistance.SuppliesRepository
{
    public class SuppliesRepository : ISuppliesRepository
    {
        public async Task<List<Supplier>> Up_GetSuppliers()
        {
            // Simulación de obtener proveedores
            List<Supplier> suppliers = new List<Supplier>
            {
                new Supplier { Id = 1, Name = "SupplierA", Description = "Supplier A Description", RFC = "RFC123", CP = "12345", Adress = "Address1", CreditDays = 30, Available = true },
                new Supplier { Id = 2, Name = "SupplierB", Description = "Supplier B Description", RFC = "RFC456", CP = "67890", Adress = "Address2", CreditDays = 45, Available = true },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(suppliers);
        }

        public async Task<Supplier> Up_GetSupplierByPK(int SupplierPK)
        {
            // Simulación de obtener un proveedor por su clave primaria
            Supplier supplier = new Supplier { Id = SupplierPK, Name = "SupplierC", Description = "Supplier C Description", RFC = "RFC789", CP = "54321", Adress = "Address3", CreditDays = 60, Available = true };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(supplier);
        }

        public async Task<InsertGenericResult> InsertSupplier(Supplier Supplier)
        {
            // Simulación de inserción de un nuevo proveedor
            InsertGenericResult result = new InsertGenericResult { Message = "Proveedor insertado correctamente", Id = 987 }; // Se asume un valor de clave primaria ficticio (987)

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_UpdateSupplier(Supplier Supplier)
        {
            // Simulación de actualización de un proveedor
            string result = "Proveedor actualizado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_DeleteSupplier(int PkSupplier)
        {
            // Simulación de eliminación de un proveedor por su clave primaria
            string result = "Proveedor eliminado correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }
    }
}
