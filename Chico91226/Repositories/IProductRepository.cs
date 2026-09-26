using Chico91226.MODELS.Data;
using Chico91226.MODELS.Domain;
using Microsoft.EntityFrameworkCore;
namespace Chico91226.Repositories
{
        public interface IProductRepository
        {
            Task<IEnumerable<Product>> GetAllAsync();
            Task<Product?> GetByIdAsync(int id);
            Task<Product> CreateAsync(Product product);
            Task<Product?> UpdateAsync(Product product);
            Task<bool> DeleteAsync(int id);
            Task AddAsync(Product entity);
        }
}