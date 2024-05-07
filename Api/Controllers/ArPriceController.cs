using API_CHASKAS.Api.Common;
using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities.Inserts;
using Microsoft.AspNetCore.Mvc;

namespace API_CHASKAS.Api.Controllers
{
    [Route("arprice")]
    public class ArPriceController: ControllerBase
    {
          private readonly ILogger<ArPriceController> _logger;

          private readonly IArPriceService _service;

        public ArPriceController(ILogger<ArPriceController> logger, IArPriceService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpPost("arpricebyproduct")]
        public async Task<ActionResult<List<DtoArPrice>>> GetArPricesByFKProduct([FromBody] GenericRequest genericRequest)
        {
            List<DtoArPrice> list = await _service.GetArPricesByFKProduct(genericRequest.FKProduct);
            return Ok(list);
        }
        [HttpPost("arpricebyproductrange")]
        public async Task<ActionResult<List<DtoArPrice>>> GetArPricesByFKProductAndRangeOfDates([FromBody] ArPriceRequest genericRequest)
        {
            List<DtoArPrice> list = await _service.GetArPricesByFKProductAndRangeOfDates(genericRequest.FKProduct, genericRequest.start, genericRequest.end);
            return Ok(list);
        }

        [HttpPost("arpricebypk")]
        public async Task<ActionResult<List<DtoArPrice>>> GetArPriceById([FromBody] ArPriceRequest genericRequest)
        {
            DtoArPrice list = await _service.GetArPriceById(genericRequest.Id);
            return Ok(list);
        }

        [HttpPost("arprice")]
        public async Task<ActionResult<InsertGenericResult>> InsertArPrice([FromBody] DtoArPrice dto)
        {
            InsertGenericResult obj = await _service.InsertArPrice(dto);
            return Ok(obj);
        }
        [HttpPatch("arprice")]
        public async Task<ActionResult<InsertGenericResult>> UpdateArPrice([FromBody] DtoArPrice dto)
        {
             InsertGenericResult resultGeneric = new InsertGenericResult();
            try{
                 
                string result = await _service.UpdateArPrice(dto);
                resultGeneric.Message = result;
                resultGeneric.Id= dto.Id;
                return Ok(resultGeneric );

            }catch(Exception ex){
                Console.WriteLine(ex.Message);
                 return StatusCode(500, "Internal server error");
            }  
            
           
        }
        [HttpDelete("arprice")]
        public async Task<ActionResult<InsertGenericResult>> DeleteArPrice([FromBody] ArPriceRequest genericRequest)
        {
             InsertGenericResult resultGeneric = new InsertGenericResult();
            try{
                 
                string result = await _service.DeleteArPrice(genericRequest.Id);
                resultGeneric.Message = result;
                resultGeneric.Id= genericRequest.Id;
                return Ok(resultGeneric );

            }catch(Exception ex){
                Console.WriteLine(ex.Message);
                 return StatusCode(500, "Internal server error");
            }  
            
           
        }
        
        
        
    }
}