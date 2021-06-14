using DreamLikeDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public interface IBlockedCategoryDAL
    {
        Task AddBlockedCategory(BlockedCategory blockedCategory);
        Task DeleteBlockedCategory(int id);
        Task<BlockedCategory> GetBlockedCategoryById(int id);
        Task<List<BlockedCategory>> GetAllBlockedCategories();
        Task UpdateBlockedCategory(int id, BlockedCategory blockedCategory);
    }
}
