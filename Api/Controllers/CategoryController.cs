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
    [Route("category")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryService _service;

        public CategoryController(ILogger<CategoryController> logger, ICategoryService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("categories")]
        public async Task<ActionResult<List<DtoCategory>>> GetCategories()
        {
            List<DtoCategory> list = await _service.GetCategories();
            return Ok(list);
        }

        [HttpGet("category/{id}")]
        public async Task<ActionResult<DtoCategory>> GetCategoryById(int id)
        {
            DtoCategory category = await _service.GetCategoryById(id);
            return Ok(category);
        }

        [HttpPost("category")]
        public async Task<ActionResult<InsertGenericResult>> InsertCategory([FromBody] DtoCategory dto)
        {
            InsertGenericResult result = await _service.InsertCategory(dto);
            return Ok(result);
        }

        [HttpPatch("category")]
        public async Task<ActionResult<InsertGenericResult>> UpdateCategory([FromBody] DtoCategory dto)
        {
            try
            {
                string result = await _service.UpdateCategory(dto);
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

        [HttpDelete("category/{id}")]
        public async Task<ActionResult<InsertGenericResult>> DeleteCategory(int id)
        {
            try
            {
                string result = await _service.DeleteCategory(id);
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
