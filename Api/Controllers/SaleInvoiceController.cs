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
    [Route("saleinvoice")]
    public class SaleInvoiceController : ControllerBase
    {
        private readonly ILogger<SaleInvoiceController> _logger;
        private readonly ISaleInvoiceService<DtoSaleInvoice> _service;

        public SaleInvoiceController(ILogger<SaleInvoiceController> logger, ISaleInvoiceService<DtoSaleInvoice> service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("saleinvoices")]
        public async Task<ActionResult<List<DtoSaleInvoice>>> GetSaleInvoices()
        {
            List<DtoSaleInvoice> list = await _service.GetSaleInvoces();
            return Ok(list);
        }

        [HttpGet("saleinvoice/{pk}")]
        public async Task<ActionResult<DtoSaleInvoice>> GetSaleInvoiceByPK(int pk)
        {
            DtoSaleInvoice saleInvoice = await _service.GetSaleInvoceByPK(pk);
            return Ok(saleInvoice);
        }

        [HttpPost("saleinvoice")]
        public async Task<ActionResult<InsertGenericResult>> InsertSaleInvoice([FromBody] DtoSaleInvoice dto)
        {
            InsertGenericResult result = await _service.InsertSaleInvoce(dto);
            return Ok(result);
        }

        [HttpPatch("saleinvoice")]
        public async Task<ActionResult<InsertGenericResult>> UpdateSaleInvoice([FromBody] DtoSaleInvoice dto)
        {
            try
            {
                string result = await _service.UpdateSaleInvoce(dto);
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

        [HttpDelete("saleinvoice/{id}")]
        public async Task<ActionResult<InsertGenericResult>> DeleteSaleInvoice(int id)
        {
            try
            {
                string result = await _service.DeleteSaleInvoce(id);
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
