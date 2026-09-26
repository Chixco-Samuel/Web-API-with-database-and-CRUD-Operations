using Chico91226.MODELS.Dto;
namespace Chico91226.Services
{
        public interface IProductService
        {
            Task<IEnumerable<ProductDto>> GetAllAsync();
            Task<ProductDto> GetByIdAsync(int id);
            Task<ProductDto> CreateAsync(CreateProductDto input);
        }
    
}