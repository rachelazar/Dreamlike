using DreamLikeBL;
using DreamLikeDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamLike.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryBL _categoryBL;
        public CategoryController(ICategoryBL categoryBl)
        {
            _categoryBL = categoryBl;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDTO>>> GetAllCategorys()
        {
            var categoryData = await _categoryBL.GetAllCategorys();
            if (categoryData == null)
            {
                return NoContent();

            }
            return Ok(categoryData);
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<List<CategoryDTO>>> GetCategoryById(int id)
        {
            var categoryData = await _categoryBL.GetCategoryById(id);
            if (categoryData == null)
            {
                return NoContent();

            }
            return Ok(categoryData);
        }

        [HttpPost]
        public async Task AddCategory([FromBody] CategoryDTO category)
        {
            await _categoryBL.AddCategory(category);
        }

        [HttpDelete("{id}")]
        public async Task DeleteCategory([FromRoute] int id)
        {
            await _categoryBL.DeleteCategory(id);
        }
    }
}
