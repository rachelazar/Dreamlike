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
    public class BlockedCategoryController : ControllerBase
    {
        IBlockedCategoryBL _blockedCategoryBL;
        public BlockedCategoryController(IBlockedCategoryBL blockedCategoryBl)
        {
            _blockedCategoryBL = blockedCategoryBl;
        }

        [HttpGet]
        public async Task<ActionResult<List<BlockedCategoryDTO>>> GetAllblockedCategories()
        {
            var blockedCategoryData = await _blockedCategoryBL.GetAllBlockedCategories();
            if (blockedCategoryData == null)
            {
                return NoContent();

            }
            return Ok(blockedCategoryData);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<BlockedCategoryDTO>>> GetBlockedCategoryById(int id)
        {
            var blockedCategoryData = await _blockedCategoryBL.GetBlockedCategoryById(id);
            if (blockedCategoryData == null)
            {
                return NoContent();

            }
            return Ok(blockedCategoryData);
        }

        [HttpPost]
        public async Task AddBlockedCategory([FromBody] BlockedCategoryDTO blockedCategory)
        {
            await _blockedCategoryBL.AddBlockedCategory(blockedCategory);
        }

        [HttpDelete("{id}")]
        public async Task DeleteBlockedCategory([FromRoute] int id)
        {
            await _blockedCategoryBL.DeleteBlockedCategory(id);
        }

    }
}
