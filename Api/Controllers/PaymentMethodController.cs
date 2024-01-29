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
    [Route("paymentmethod")]
    public class PaymentMethodController : ControllerBase
    {
        private readonly ILogger<PaymentMethodController> _logger;
        private readonly IPaymentMethodService<DtoPaymentMethod> _service;

        public PaymentMethodController(ILogger<PaymentMethodController> logger, IPaymentMethodService<DtoPaymentMethod> service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("paymentmethods")]
        public async Task<ActionResult<List<DtoPaymentMethod>>> GetPaymentMethods()
        {
            List<DtoPaymentMethod> list = await _service.GetPaymentMethods();
            return Ok(list);
        }

        [HttpGet("paymentmethod/{pk}")]
        public async Task<ActionResult<DtoPaymentMethod>> GetPaymentMethodByPK(int pk)
        {
            DtoPaymentMethod paymentMethod = await _service.GetPaymentMethodByPK(pk);
            return Ok(paymentMethod);
        }

        [HttpPost("paymentmethod")]
        public async Task<ActionResult<InsertGenericResult>> InsertPaymentMethod([FromBody] DtoPaymentMethod dto)
        {
            InsertGenericResult result = await _service.InsertPaymentMethod(dto);
            return Ok(result);
        }

        [HttpPatch("paymentmethod")]
        public async Task<ActionResult<InsertGenericResult>> UpdatePaymentMethod([FromBody] DtoPaymentMethod dto)
        {
            try
            {
                string result = await _service.UpdatePaymentMethod(dto);
                InsertGenericResult resultGeneric = new InsertGenericResult
                {
                    Message = result,
                    Pk = dto.PK
                };
                return Ok(resultGeneric);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("paymentmethod/{pk}")]
        public async Task<ActionResult<InsertGenericResult>> DeletePaymentMethod(int pk)
        {
            try
            {
                string result = await _service.DeletePaymentMethod(pk);
                InsertGenericResult resultGeneric = new InsertGenericResult
                {
                    Message = result,
                    Pk = pk
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
