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
    public class ManagerController : ControllerBase
    {
        IManagerBL _managerBL;
        public ManagerController(IManagerBL managerBl)
        {
            _managerBL = managerBl;
        }

        [HttpGet]
        public async Task<ActionResult<List<ManagerDTO>>> GetAllManagers()
        {
            var managerData = await _managerBL.GetAllManagers();
            if (managerData == null)
            {
                return NoContent();

            }
            return Ok(managerData);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<ManagerDTO>>> GetManagerById(int id)
        {
            var managerData = await _managerBL.GetManagerById(id);
            if (managerData == null)
            {
                return NoContent();

            }
            return Ok(managerData);
        }

        [HttpPost]
        public async Task AddManager([FromBody] ManagerDTO manager)
        {
            await _managerBL.AddManager(manager);
        }

        [HttpDelete("{id}")]
        public async Task DeleteManager([FromRoute] int id)
        {
            await _managerBL.DeleteManager(id);
        }
    }
}
