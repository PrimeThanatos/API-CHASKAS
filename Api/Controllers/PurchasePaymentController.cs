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
    [Route("purchasepayment")]
    public class PurchasePaymentController : ControllerBase
    {
        private readonly ILogger<PurchasePaymentController> _logger;
        private readonly IPurchasePaymentService<DtoPurchasePayment> _service;

        public PurchasePaymentController(ILogger<PurchasePaymentController> logger, IPurchasePaymentService<DtoPurchasePayment> service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("purchasepayments")]
        public async Task<ActionResult<List<DtoPurchasePayment>>> GetPurchasePayments()
        {
            List<DtoPurchasePayment> list = await _service.GetPurchasePayments();
            return Ok(list);
        }

        [HttpGet("purchasepayment/{pk}")]
        public async Task<ActionResult<DtoPurchasePayment>> GetPurchasePaymentByPK(int pk)
        {
            DtoPurchasePayment purchasePayment = await _service.GetPurchasePaymentByPK(pk);
            return Ok(purchasePayment);
        }

        [HttpPost("purchasepayment")]
        public async Task<ActionResult<InsertGenericResult>> InsertPurchasePayment([FromBody] DtoPurchasePayment dto)
        {
            InsertGenericResult result = await _service.InsertPurchasePayment(dto);
            return Ok(result);
        }

        [HttpPatch("purchasepayment")]
        public async Task<ActionResult<InsertGenericResult>> UpdatePurchasePayment([FromBody] DtoPurchasePayment dto)
        {
            try
            {
                string result = await _service.UpdatePurchasePayment(dto);
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

        [HttpDelete("purchasepayment/{id}")]
        public async Task<ActionResult<InsertGenericResult>> DeletePurchasePayment(int id)
        {
            try
            {
                string result = await _service.DeletePurchasePayment(id);
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
