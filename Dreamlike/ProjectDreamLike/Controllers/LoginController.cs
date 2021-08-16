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
    public class LoginController : ControllerBase
    {
        ILoginBL _loginBL;
        public LoginController(ILoginBL loginBl)
        {
            _loginBL = loginBl;
        }

        //[HttpPost]
        //public async Task<UserDTO> Login([FromBody] LoginDTO login)
        //{

        //    return await _loginBL.Login(login);
        //}

        [HttpPost]
        public async Task<ActionResult<int>> Login(LoginDTO login)
        {
            var userData = await _loginBL.Login(login);
            if (userData == 0)
            {
                return NoContent();

            }
            return Ok(userData);
        }
    }
}
