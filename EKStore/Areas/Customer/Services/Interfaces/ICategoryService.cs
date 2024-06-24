using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EKStore.Models;

namespace EKStore.Areas.Customer.Services.Interfaces
{
    public interface ICategoryService
    {
        public Task<bool> AddAsync(Category category);
        public Task<bool> UpdateAsync(Category category);
        public Task<bool> DeleteAsync(int id);
        public Task<Category> GetByIdAsync(int id);
        public Task<List<Category>> GetAllAsync();
    }
}