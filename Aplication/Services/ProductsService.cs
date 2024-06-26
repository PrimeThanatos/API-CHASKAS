using API_CHASKAS.Aplication.DTOs;
using API_CHASKAS.Aplication.Interfaces;
using API_CHASKAS.Domain.Entities;
using API_CHASKAS.Domain.Entities.Inserts;
using API_CHASKAS.Domain.Interfaces;

namespace API_CHASKAS.Aplication.Services
{
    public class ProductsService : IProductsService<DtoProducts>
    {
        IProductsRepository _repository;

        public ProductsService(IProductsRepository productsRepository)
        {
            _repository = productsRepository;
        }
        public   async Task<string> DeleteProduct(int id)
        {
           return await _repository.up_DeleteProducts(id);
        }

        public async Task<DtoProducts> GetProductById(int id)
        {
              var obj = await _repository.Up_GetProductById(id);
            return MapEntityToDto(obj);
        }

        public async Task<List<DtoProducts>> GetProducts()
        {
             var listObject =await  _repository.Up_GetProducts();
            return MapEntitiesToDtoList(listObject);
        }

        public async Task<InsertGenericResult> InsertProduct(DtoProducts dto)
        {
             var obj = MapDtoToEntity(dto);
            return await _repository.InsertProducts(obj);
        }

        public async Task<string> UpdateProduct(DtoProducts dto)
        {
              var obj = MapDtoToEntity(dto);
            return await _repository.up_UpdateProducts(obj);
        }
        
        
        // Métodos de mapeo entre Dto y entidad

        private  List<DtoProducts> MapEntitiesToDtoList(List<Products> dto)
        {
            return dto.Select(MapEntityToDto).ToList();
        }

        private  DtoProducts MapEntityToDto(Products entity)
        {
            return new DtoProducts
            { 
                Id = entity.Id,
                FKProduct = entity.FKProduct,
                FKCategory = entity.FKCategory,
                Product = entity.Name,
                Size = entity.Size,
                Weight = entity.Weight,     
                PreparationTime = entity.PreparationTime,
                Cost = entity.Cost,
                SellingPrice = entity.SellingPrice,
                Currency = entity.Currency,
                ExchangeRate = entity.ExchangeRate,
                CreatedDate = entity.CreatedDate,
                ExpirationDate = entity.ExpirationDate,
            };
        }

        private Products MapDtoToEntity(DtoProducts dto)
        {
            return new Products
            {
                Id = dto.Id,
                FKProduct = dto.FKProduct,
                FKCategory = dto.FKCategory,
                Name = dto.Product,
                Size = dto.Size,
                Weight = dto.Weight,     
                PreparationTime = dto.PreparationTime,
                Cost = dto.Cost,
                SellingPrice = dto.SellingPrice,
                Currency = dto.Currency,
                ExchangeRate = dto.ExchangeRate,
                CreatedDate = dto.CreatedDate,
                ExpirationDate = dto.ExpirationDate,
                 
            };
        }

        public async Task<List<DtoProducts>> GetProductsByCategory(string category)
        {
            var listObject =await  _repository.Up_GetProductsByCategory(category);
            return MapEntitiesToDtoList(listObject);
        }
    }
}