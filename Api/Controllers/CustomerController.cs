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
    [Route("customer")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerService<DtoCustomer> _service;

        public CustomerController(ILogger<CustomerController> logger, ICustomerService<DtoCustomer> service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("customers")]
        public async Task<ActionResult<List<DtoCustomer>>> GetCustomers()
        {
            List<DtoCustomer> list = await _service.GetCustomers();
            return Ok(list);
        }

        [HttpGet("customer/{customerPK}")]
        public async Task<ActionResult<DtoCustomer>> GetCustomerByPK(int customerPK)
        {
            DtoCustomer customer = await _service.GetCustomerByPK(customerPK);
            return Ok(customer);
        }

        [HttpPost("customer")]
        public async Task<ActionResult<InsertGenericResult>> InsertCustomer([FromBody] DtoCustomer dto)
        {
            InsertGenericResult result = await _service.InsertCustomer(dto);
            return Ok(result);
        }

       [HttpPatch("customer")]
        public async Task<ActionResult<InsertGenericResult>> UpdateCustomer([FromBody] DtoCustomer dto)
        {
            try
            {
                string result = await _service.UpdateCustomer(dto);
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

        [HttpDelete("customer/{pk}")]
        public async Task<ActionResult<InsertGenericResult>> DeleteCustomer(int pk)
        {
            try
            {
                string result = await _service.DeleteCustomer(pk);
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
