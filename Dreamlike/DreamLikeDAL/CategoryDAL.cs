using DreamLikeDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public class CategoryDAL : ICategoryDAL
    {
        DreamlikeContext _contextDB;
        public CategoryDAL(DreamlikeContext contextDB)
        {
            _contextDB = contextDB;
        }
        public async Task AddCategory(Category category)
        {
            try
            {
                await _contextDB.Categories.AddAsync(category);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteCategory(int id)
        {
            try
            {
                var categoryToDelete = await _contextDB.Categories.Where(i => i.CategoryId == id).FirstOrDefaultAsync();
                _contextDB.Categories.Remove(categoryToDelete);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Category>> GetAllCategorys()
        {
            try
            {
                return await _contextDB.Categories.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Category> GetCategoryById(int id)
        {
            try
            {
                var category = await _contextDB.Categories.Where(a => a.CategoryId == id).FirstOrDefaultAsync();
                return category;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateCategory(int id, Category category)
        {
            try
            {
                var categoryToUpdate = _contextDB.Categories.SingleOrDefault(a => a.CategoryId == id);
                categoryToUpdate.CategoryId = category.CategoryId;
                categoryToUpdate.Description = category.Description;
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
