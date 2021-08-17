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
    public class UserController : ControllerBase
    {
        IUserBL _userBL;
        public UserController(IUserBL userBl)
        {
            _userBL = userBl;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDTO>>> GetAllUsers()
        {
            var userData = await _userBL.GetAllUsers();
            if (userData == null)
            {
                return NoContent();

            }
            return Ok(userData);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<UserDTO>>> GetUserById(int id)
        {
            var userData = await _userBL.GetUserById(id);
            if (userData == null)
            {
                return NoContent();

            }
            return Ok(userData);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task AddUser([FromBody] UserDTO user)
        {
            await _userBL.AddUser(user);
        }

        [HttpDelete("{id}")]
        public async Task DeleteUser([FromRoute] int id)
        {
            await _userBL.DeleteUser(id);
        }
    }
}
