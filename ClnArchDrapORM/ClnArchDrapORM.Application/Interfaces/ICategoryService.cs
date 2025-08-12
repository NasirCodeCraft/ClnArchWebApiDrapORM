using ClnArchDrapORM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnArchDrapORM.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryDto>> GetAllAsync();
        Task<CategoryDto?> GetByIdAsync(int id);
        Task<CategoryDto> AddAsync(CategoryDto categoryDto);
        Task UpdateAsync(CategoryDto categoryDto);
        Task DeleteAsync(int id);
    }
}