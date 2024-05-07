using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Infrastructure.Persistance.SaleInvoiceRepository
{
    public class SaleInvoiceRepository: ISaleInvoiceRepository
    {
        public async Task<List<SaleInvoice>> Up_GetSaleInvoices()
        {
            // Simulación de obtener facturas de venta
            List<SaleInvoice> saleInvoices = new List<SaleInvoice>
            {
                new SaleInvoice { Id = 1, FKCustomer = 401, FKPaymentMethod = 1, Date = DateTime.Now.AddDays(-15), Total = 120, Cancel = false, Available = 1 },
                new SaleInvoice { Id = 2, FKCustomer = 402, FKPaymentMethod = 2, Date = DateTime.Now.AddDays(-10), Total = 200, Cancel = true, Available = 1 },
                // Agrega más datos ficticios según sea necesario
            };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(saleInvoices);
        }

        public async Task<SaleInvoice> Up_GetSaleInvoiceByPK(int pk)
        {
            // Simulación de obtener una factura de venta por su clave primaria
            SaleInvoice saleInvoice = new SaleInvoice { Id = pk, FKCustomer = 403, FKPaymentMethod = 3, Date = DateTime.Now.AddDays(-5), Total = 300, Cancel = false, Available = 1 };

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(saleInvoice);
        }

        public async Task<InsertGenericResult> InsertSaleInvoice(SaleInvoice saleInvoice)
        {
            // Simulación de inserción de una nueva factura de venta
            InsertGenericResult result = new InsertGenericResult { Message = "Factura de venta insertada correctamente", Id = 987 }; // Se asume un valor de clave primaria ficticio (987)

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_UpdateSaleInvoice(SaleInvoice SaleInvoice)
        {
            // Simulación de actualización de una factura de venta
            string result = "Factura de venta actualizada correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }

        public async Task<string> up_DeleteSaleInvoice(int pk)
        {
            // Simulación de eliminación de una factura de venta por su clave primaria
            string result = "Factura de venta eliminada correctamente";

            // Utiliza Task.FromResult para devolver una tarea completada con el resultado
            return await Task.FromResult(result);
        }
    }
}