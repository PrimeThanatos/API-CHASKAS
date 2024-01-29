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
    [Route("supplier")]
    public class SupplierController : ControllerBase
    {
        private readonly ILogger<SupplierController> _logger;
        private readonly ISupplierService<DtoSupplier> _service;

        public SupplierController(ILogger<SupplierController> logger, ISupplierService<DtoSupplier> service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("suppliers")]
        public async Task<ActionResult<List<DtoSupplier>>> GetSuppliers()
        {
            List<DtoSupplier> list = await _service.GetSuppliers();
            return Ok(list);
        }

        [HttpGet("supplier/{pk}")]
        public async Task<ActionResult<DtoSupplier>> GetSupplierByPK(int pk)
        {
            DtoSupplier supplier = await _service.GetSupplierByPK(pk);
            return Ok(supplier);
        }

        [HttpPost("supplier")]
        public async Task<ActionResult<InsertGenericResult>> InsertSupplier([FromBody] DtoSupplier dto)
        {
            InsertGenericResult result = await _service.InsertSupplier(dto);
            return Ok(result);
        }

        [HttpPatch("supplier")]
        public async Task<ActionResult<InsertGenericResult>> UpdateSupplier([FromBody] DtoSupplier dto)
        {
            try
            {
                string result = await _service.UpdateSupplier(dto);
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

        [HttpDelete("supplier/{pk}")]
        public async Task<ActionResult<InsertGenericResult>> DeleteSupplier(int pk)
        {
            try
            {
                string result = await _service.DeleteSupplier(pk);
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
