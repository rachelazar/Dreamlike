using DreamLikeDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public interface ICategoryDAL
    {
        Task UpdateCategory(int id, Category category);
        Task<List<Category>> GetAllCategorys();
        Task<Category> GetCategoryById(int id);
        Task AddCategory(Category category);
        Task DeleteCategory(int id);
    }
}
