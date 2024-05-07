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
    [Route("recipe")]
    public class RecipeController : ControllerBase
    {
        private readonly ILogger<RecipeController> _logger;
        private readonly IRecipeService<DtoRecipe> _service;

        public RecipeController(ILogger<RecipeController> logger, IRecipeService<DtoRecipe> service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("recipes")]
        public async Task<ActionResult<List<DtoRecipe>>> GetRecipes()
        {
            List<DtoRecipe> list = await _service.GetRecipes();
            return Ok(list);
        }

        [HttpGet("recipe/{id}")]
        public async Task<ActionResult<DtoRecipe>> GetRecipeById(int id)
        {
            DtoRecipe recipe = await _service.GetRecipeById(id);
            return Ok(recipe);
        }

        [HttpPost("recipe")]
        public async Task<ActionResult<InsertGenericResult>> InsertRecipe([FromBody] DtoRecipe dto)
        {
            InsertGenericResult result = await _service.InsertRecipe(dto);
            return Ok(result);
        }

        [HttpPatch("recipe")]
        public async Task<ActionResult<InsertGenericResult>> UpdateRecipe([FromBody] DtoRecipe dto)
        {
            try
            {
                string result = await _service.UpdateRecipe(dto);
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

        [HttpDelete("recipe/{id}")]
        public async Task<ActionResult<InsertGenericResult>> DeleteRecipe(int id)
        {
            try
            {
                string result = await _service.DeleteRecipe(id);
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
