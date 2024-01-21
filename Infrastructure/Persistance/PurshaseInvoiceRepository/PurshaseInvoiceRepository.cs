using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Infrastructure.Persistance.PurshaseInvoiceRepository
{
    public class PurshaseInvoiceRepository: IPurshaseInvoiceRepository
    {
        public async Task<List<PurshaseInvoice>> Up_GetPurshaseInvoices()
        {
            // Simulación de obtener facturas de compra
            List<PurshaseInvoice> purshaseInvoices = new List<PurshaseInvoice>
            {
                new PurshaseInvoice { PK = 1, FKSupplier = 101, Date = DateTime.Now.AddDays(-30), FKPaymentMethod = 1, IsCredit = false, Total = 500, Cancel = false, Available = 1 },
                new PurshaseInvoice { PK = 2, FKSupplier = 102, Date = DateTime.Now.AddDays(-25), FKPaymentMethod = 2, IsCredit = true, Total = 800, Cancel = false, Available = 1 },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(purshaseInvoices);
        }

        public async Task<PurshaseInvoice> Up_GetPurshaseInvoiceByPK(int purshaseInvoicePK)
        {
            // Simulación de obtener una factura de compra por su clave primaria
            PurshaseInvoice purshaseInvoice = new PurshaseInvoice { PK = purshaseInvoicePK, FKSupplier = 103, Date = DateTime.Now.AddDays(-20), FKPaymentMethod = 3, IsCredit = true, Total = 1200, Cancel = false, Available = 1 };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(purshaseInvoice);
        }

        public async Task<InsertGenericResult> InsertPurshaseInvoice(PurshaseInvoice purshaseInvoice)
        {
            // Simulación de inserción de una nueva factura de compra
            InsertGenericResult result = new InsertGenericResult { Message = "Factura de compra insertada correctamente", Pk = 789 }; // Se asume un valor de clave primaria ficticio (789)

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_UpdatePurshaseInvoice(PurshaseInvoice purshaseInvoice)
        {
            // Simulación de actualización de una factura de compra
            string result = "Factura de compra actualizada correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_DeletePurshaseInvoice(int pkPurshaseInvoice)
        {
            // Simulación de eliminación de una factura de compra por su clave primaria
            string result = "Factura de compra eliminada correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }
    }
}