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
    [Route("step")]
    public class StepController : ControllerBase
    {
        private readonly ILogger<StepController> _logger;
        private readonly IStepService<DtoStep> _service;

        public StepController(ILogger<StepController> logger, IStepService<DtoStep> service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("steps")]
        public async Task<ActionResult<List<DtoStep>>> GetSteps()
        {
            List<DtoStep> list = await _service.GetSteps();
            return Ok(list);
        }

        [HttpGet("step/{pk}")]
        public async Task<ActionResult<DtoStep>> GetStepByPK(int pk)
        {
            DtoStep step = await _service.GetStepByPK(pk);
            return Ok(step);
        }

        [HttpPost("step")]
        public async Task<ActionResult<InsertGenericResult>> InsertStep([FromBody] DtoStep dto)
        {
            InsertGenericResult result = await _service.InsertStep(dto);
            return Ok(result);
        }

        [HttpPatch("step")]
        public async Task<ActionResult<InsertGenericResult>> UpdateStep([FromBody] DtoStep dto)
        {
            try
            {
                string result = await _service.UpdateStep(dto);
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

        [HttpDelete("step/{pk}")]
        public async Task<ActionResult<InsertGenericResult>> DeleteStep(int pk)
        {
            try
            {
                string result = await _service.DeleteStep(pk);
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
