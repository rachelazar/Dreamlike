using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public interface ICategoryBL
    {
        Task<List<CategoryDTO>> GetAllCategorys();
        Task<CategoryDTO> GetCategoryById(int id);
        Task AddCategory(CategoryDTO category);
        Task DeleteCategory(int id);
        Task UpdateCategory(int id, CategoryDTO category);
    }
}
