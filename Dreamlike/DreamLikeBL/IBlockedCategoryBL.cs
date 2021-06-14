using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public interface IBlockedCategoryBL
    {
        Task<List<BlockedCategoryDTO>> GetAllBlockedCategories();
        Task<BlockedCategoryDTO> GetBlockedCategoryById(int id);
        Task AddBlockedCategory(BlockedCategoryDTO blockedCategory);
        Task DeleteBlockedCategory(int id);
        Task UpdateBlockedCategory(int id, BlockedCategoryDTO blockedCategory);
    }
}
