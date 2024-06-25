using EKStore.Models;

namespace EKStore.Areas.Customer.Services.Interfaces
{
    public interface ICategoryService
    {
        public Task<Category> GetByIdAsync(int id);
        public Task<List<Category>> GetAllAsync();
    }
}
