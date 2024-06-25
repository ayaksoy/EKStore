using EKStore.Areas.Customer.Services.Interfaces;
using EKStore.Data;
using EKStore.Models;
using Microsoft.EntityFrameworkCore;

namespace EKStore.Areas.Customer.Services.Models
{
    public class CategoryService : ICategoryService
    {
        ApplicationDbContext db;

        public CategoryService(ApplicationDbContext db)
        {
            this.db = db;
        }


        public Task<List<Category>> GetAllAsync()
        {
            var list=db.Category.Where(c => !c.IsDelete).ToListAsync();

            return list;
        }

        public Task<Category> GetByIdAsync(int id)
        {
            var category=db.Category.FirstOrDefaultAsync(c=>c.Id == id && !c.IsDelete);

            return category;
        }

 
    }
}
