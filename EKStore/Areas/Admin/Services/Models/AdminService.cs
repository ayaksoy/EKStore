using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EKStore.Areas.Admin.Services.Interfaces;
using EKStore.Data;
using EKStore.Models;
using Microsoft.EntityFrameworkCore;

namespace EKStore.Areas.Admin.Services.Models
{
    public class AdminService : IAdminService
    {
        private readonly ApplicationDbContext db;
        public AdminService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public Task<bool> AddAsync(Category category)
        {
            var result = false;
            if (category != null)
            {
                db.Category.AddAsync(category);
                db.SaveChanges();
                result = true;
            }
            return Task.FromResult(result);
        }

        public Task<bool> DeleteAsync(int id)
        {
            var result = false;
            var category = db.Category.Find(id);
            if (category != null && category.IsDelete == false)
            {
                category.IsDelete = true;
                db.SaveChanges();
                result = true;
            }
            return Task.FromResult(result);
        }

        public Task<List<Category>> GetAllAsync()
        {
            var list = db.Category.Where(c => c.IsDelete == false).ToListAsync();
            return list;
        }

        public Task<Category> GetByIdAsync(int id)
        {
            var category = db.Category.FirstOrDefaultAsync(c => c.Id == id && c.IsDelete == false);
            return category;
        }

        public Task<bool> UpdateAsync(Category category)
        {
            var result = false;
            var oldCategory = db.Category.FirstOrDefault(c => c.Id == category.Id);
            if (oldCategory != null)
            {
                oldCategory.Name = category.Name;
                oldCategory.Description = category.Description;
                oldCategory.IsStatus = category.IsStatus;

                if (String.IsNullOrEmpty(category.Image))
                {
                    oldCategory.Image = category.Image;
                }

                db.SaveChanges();
                result = true;
            }
            return Task.FromResult(result);
        }
    }
}