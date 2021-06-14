using AutoMapper;
using DreamLikeDAL;
using DreamLikeDAL.Models;
using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public class CategoryBL : ICategoryBL
    {
        ICategoryDAL categoryDal;
        IMapper mapper;

        public CategoryBL(ICategoryDAL _categoryDal)
        {
            categoryDal = _categoryDal;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }

        public async Task AddCategory(CategoryDTO category)
        {
            var _category = mapper.Map<CategoryDTO, Category>(category);
            await categoryDal.AddCategory(_category);
        }

        public async Task DeleteCategory(int id)
        {
            await categoryDal.DeleteCategory(id);
        }

        public async Task<CategoryDTO> GetCategoryById(int id)
        {
            Category _category = await categoryDal.GetCategoryById(id);
            var convertCategory = mapper.Map<Category, CategoryDTO>(_category);
            return convertCategory;
        }

        public async Task<List<CategoryDTO>> GetAllCategorys()
        {
            List<Category> listCategorys = await categoryDal.GetAllCategorys();
            var _category = mapper.Map<List<Category>, List<CategoryDTO>>(listCategorys);
            return _category;
        }

        public async Task UpdateCategory(int id, CategoryDTO category)
        {
            var _category = mapper.Map<CategoryDTO, Category>(category);
            await categoryDal.UpdateCategory(id, _category);
        }


        
    }
}
