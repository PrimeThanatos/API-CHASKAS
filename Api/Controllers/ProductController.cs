using API_CHASKAS.Api.Common;
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

        [HttpPost("productsbycategory")]
        public async Task<ActionResult<List<DtoProducts>>> GetProductsByCategory([FromBody] GenericRequest request)
        {

           // List<DtoProducts> dtoProducts = await _service.GetProductsByCategory(request.Category);
            List<DtoProducts> dtoProducts = new List<DtoProducts>{
                new DtoProducts(){
                     Id = 1,
                      Cost = 10,
                       CreatedDate = DateTime.Now,
                        Currency = (decimal)1.0,
                         ExchangeRate = 1,
                          ExpirationDate = DateTime.Now,
                           Product = "Gatorade",
                            Size = 500,
                             SellingPrice = 12,
                              PreparationTime = 0,
                               Weight = 500,
                                FKCategory = 1
                                

                },
                 new DtoProducts(){
                     Id = 2,
                      Cost = 15,
                       CreatedDate = DateTime.Now,
                        Currency = (decimal)1.0,
                         ExchangeRate = 1,
                          ExpirationDate = DateTime.Now,
                           Product = "Coca",
                            Size = 355,
                             SellingPrice = 18,
                              PreparationTime = 0,
                               Weight = 355,
                                FKCategory = 1
                                 

                },
                 new DtoProducts(){
                     Id = 3,
                      Cost = 15,
                       CreatedDate = DateTime.Now,
                        Currency = (decimal)1.0,
                         ExchangeRate = 1,
                          ExpirationDate = DateTime.Now,
                           Product = "Fanta",
                            Size = 355,
                             SellingPrice = 18,
                              PreparationTime = 0,
                               Weight = 355,
                                FKCategory = 1
                                 

                },
                 new DtoProducts(){
                     Id = 4,
                      Cost = 15,
                       CreatedDate = DateTime.Now,
                        Currency = (decimal)1.0,
                         ExchangeRate = 1,
                          ExpirationDate = DateTime.Now,
                           Product = "Manzanita",
                            Size = 355,
                             SellingPrice = 18,
                              PreparationTime = 0,
                               Weight = 355,
                                FKCategory = 1
                                 

                },
            };
            return Ok(dtoProducts);

        }

        [HttpGet("product/{id}")]
        public async Task<ActionResult<DtoProducts>> GetProductByPK(int pk)
        {
            DtoProducts product = await _service.GetProductById(pk);
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

        [HttpDelete("product/{id}")]
        public async Task<ActionResult<InsertGenericResult>> DeleteProduct(int id)
        {
            try
            {
                string result = await _service.DeleteProduct(id);
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
