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
    public class BlockedCategoryBL : IBlockedCategoryBL
    {
        IBlockedCategoryDAL blockedCategoryDal;
        IMapper mapper;

        public BlockedCategoryBL(IBlockedCategoryDAL _blockedCategoryDal)
        {
            blockedCategoryDal = _blockedCategoryDal;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }

        public async Task AddBlockedCategory(BlockedCategoryDTO blockedCategory)
        {
            var _blockedCategory = mapper.Map<BlockedCategoryDTO, BlockedCategory>(blockedCategory);
            await blockedCategoryDal.AddBlockedCategory(_blockedCategory);
        }

        public async Task DeleteBlockedCategory(int id)
        {
            await blockedCategoryDal.DeleteBlockedCategory(id);
        }

        public async Task<BlockedCategoryDTO> GetBlockedCategoryById(int id)
        {
            BlockedCategory _blockedCategory = await blockedCategoryDal.GetBlockedCategoryById(id);
            var convertBlockedCategory = mapper.Map<BlockedCategory, BlockedCategoryDTO>(_blockedCategory);
            return convertBlockedCategory;
        }

        public async Task<List<BlockedCategoryDTO>> GetAllBlockedCategories()
        {
            List<BlockedCategory> listBlockedCategorys = await blockedCategoryDal.GetAllBlockedCategories();
            var _blockedCategory = mapper.Map<List<BlockedCategory>, List<BlockedCategoryDTO>>(listBlockedCategorys);
            return _blockedCategory;
        }

        public async Task UpdateBlockedCategory(int id, BlockedCategoryDTO blockedCategory)
        {
            var _blockedCategory = mapper.Map<BlockedCategoryDTO, BlockedCategory>(blockedCategory);
            await blockedCategoryDal.UpdateBlockedCategory(id, _blockedCategory);
        }

    }
}
