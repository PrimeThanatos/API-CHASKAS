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
    [Route("product")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductsService<DtoProducts> _service;

        public ProductController(ILogger<ProductController> logger, IProductsService<DtoProducts> service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("products")]
        public async Task<ActionResult<List<DtoProducts>>> GetProducts()
        {
            List<DtoProducts> list = await _service.GetProducts();
            return Ok(list);
        }

        [HttpGet("product/{pk}")]
        public async Task<ActionResult<DtoProducts>> GetProductByPK(int pk)
        {
            DtoProducts product = await _service.GetProductByPK(pk);
            return Ok(product);
        }

        [HttpPost("product")]
        public async Task<ActionResult<InsertGenericResult>> InsertProduct([FromBody] DtoProducts dto)
        {
            InsertGenericResult result = await _service.InsertProduct(dto);
            return Ok(result);
        }

        [HttpPatch("product")]
        public async Task<ActionResult<InsertGenericResult>> UpdateProduct([FromBody] DtoProducts dto)
        {
            try
            {
                string result = await _service.UpdateProduct(dto);
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

        [HttpDelete("product/{pk}")]
        public async Task<ActionResult<InsertGenericResult>> DeleteProduct(int pk)
        {
            try
            {
                string result = await _service.DeleteProduct(pk);
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
