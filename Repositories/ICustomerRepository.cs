using System.Collections.Generic;
using System.Threading.Tasks;
using VibeCode.Models;

namespace VibeCode.Repositories
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(string id);
        Task AddAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task DeleteAsync(string id);
    }
}
