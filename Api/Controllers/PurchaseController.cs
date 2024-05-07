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
    [Route("purchase")]
    public class PurchaseController : ControllerBase
    {
        private readonly ILogger<PurchaseController> _logger;
        private readonly IPurchaseService<DtoPurchase> _service;

        public PurchaseController(ILogger<PurchaseController> logger, IPurchaseService<DtoPurchase> service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("purchases")]
        public async Task<ActionResult<List<DtoPurchase>>> GetPurchases()
        {
            List<DtoPurchase> list = await _service.GetPurchases();
            return Ok(list);
        }

        [HttpGet("purchase/{id}")]
        public async Task<ActionResult<DtoPurchase>> GetPurchaseById(int id)
        {
            DtoPurchase purchase = await _service.GetPurchaseById(id);
            return Ok(purchase);
        }

        [HttpPost("purchase")]
        public async Task<ActionResult<InsertGenericResult>> InsertPurchase([FromBody] DtoPurchase dto)
        {
            InsertGenericResult result = await _service.InsertPurchase(dto);
            return Ok(result);
        }

        [HttpPatch("purchase")]
        public async Task<ActionResult<InsertGenericResult>> UpdatePurchase([FromBody] DtoPurchase dto)
        {
            try
            {
                string result = await _service.UpdatePurchase(dto);
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

        [HttpDelete("purchase/{id}")]
        public async Task<ActionResult<InsertGenericResult>> DeletePurchase(int id)
        {
            try
            {
                string result = await _service.DeletePurchase(id);
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
