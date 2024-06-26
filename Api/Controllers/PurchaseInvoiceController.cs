using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities.Inserts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_CHASKAS.Api.Controllers
{
    [Route("purchaseinvoice")]
    public class PurchaseInvoiceController : ControllerBase
    {
        private readonly ILogger<PurchaseInvoiceController> _logger;
        private readonly IPurchaseInvoicesService<DtoPurchaseInvoice> _service;

        public PurchaseInvoiceController(ILogger<PurchaseInvoiceController> logger, IPurchaseInvoicesService<DtoPurchaseInvoice> service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("purchaseinvoices")]
        public async Task<ActionResult<List<DtoPurchaseInvoice>>> GetPurchaseInvoices()
        {
            List<DtoPurchaseInvoice> list = await _service.GetPurchaseInvoces();
            return Ok(list);
        }

        [HttpGet("purchaseinvoice/{Id}")]
        public async Task<ActionResult<DtoPurchaseInvoice>> GetPurchaseInvoiceById(int id)
        {
            DtoPurchaseInvoice purchaseInvoice = await _service.GetPurchaseInvoceById(id);
            return Ok(purchaseInvoice);
        }

        [HttpPost("purchaseinvoice")]
        public async Task<ActionResult<InsertGenericResult>> InsertPurchaseInvoice([FromBody] DtoPurchaseInvoice dto)
        {
            InsertGenericResult result = await _service.InsertPurchaseInvoce(dto);
            return Ok(result);
        }

        [HttpPatch("purchaseinvoice")]
        public async Task<ActionResult<InsertGenericResult>> UpdatePurchaseInvoice([FromBody] DtoPurchaseInvoice dto)
        {
            try
            {
                string result = await _service.UpdatePurchaseInvoce(dto);
                InsertGenericResult resultGeneric = new InsertGenericResult
                {
                    Message = result,
                    Id = dto.Id
                };
                return Ok(resultGeneric);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("purchaseinvoice/{Id}")]
        public async Task<ActionResult<InsertGenericResult>> DeletePurchaseInvoice(int id)
        {
            try
            {
                string result = await _service.DeletePurchaseInvoce(id);
                InsertGenericResult resultGeneric = new InsertGenericResult
                {
                    Message = result,
                    Id = id
                };
                return Ok(resultGeneric);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
