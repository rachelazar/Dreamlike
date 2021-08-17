using DreamLikeDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public class BlockedCategoryDAL : IBlockedCategoryDAL
    {
        DreamlikeContext _contextDB;
        public BlockedCategoryDAL(DreamlikeContext contextDB)
        {
            _contextDB = contextDB;
        }

        public async Task AddBlockedCategory(BlockedCategory blockedCategory)
        {
            try
            {
                await _contextDB.BlockedCategories.AddAsync(blockedCategory);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteBlockedCategory(int id)
        {
            try
            {
                var blockedCategoryToDelete = await _contextDB.BlockedCategories.Where(i => i.CategoryId== id).FirstOrDefaultAsync();
                _contextDB.BlockedCategories.Remove(blockedCategoryToDelete);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public async Task<List<BlockedCategory>> GetAllBlockedCategories()
        {
            try
            {
                return await _contextDB.BlockedCategories.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<BlockedCategory> GetBlockedCategoryById(int id)
        {
            try
            {
                var blockedCategory = await _contextDB.BlockedCategories.Where(a => a.CategoryId == id).FirstOrDefaultAsync();
                return blockedCategory;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateBlockedCategory(int id, BlockedCategory blockedCategory)
        {
            try
            {
                var blockedCategoryToUpdate = _contextDB.BlockedCategories.SingleOrDefault(a => a.CategoryId == id);
                blockedCategoryToUpdate.CategoryId = blockedCategory.CategoryId;
                blockedCategoryToUpdate.CouponId = blockedCategory.CouponId;
                blockedCategoryToUpdate.Description = blockedCategory.Description;
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
