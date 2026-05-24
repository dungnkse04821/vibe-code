using System.Collections.Generic;
using System.Threading.Tasks;
using VibeCode.Models;

namespace VibeCode.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(string sku);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(string sku);
    }
}
