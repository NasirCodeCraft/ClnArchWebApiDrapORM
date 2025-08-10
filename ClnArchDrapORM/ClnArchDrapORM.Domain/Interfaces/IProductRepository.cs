using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClnArchDrapORM.Domain.Entities;


namespace ClnArchDrapORM.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task<Product>AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAysnc(int id);
    }
}
