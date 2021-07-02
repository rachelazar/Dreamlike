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
    public class LoginBL : ILoginBL
    {
        ILoginDAL loginDal;
        IMapper mapper;
        public async Task<UserDTO> Login(LoginDTO login)
        {
            User _user = await loginDal.Login(login.Username, login.Password);
            var convertUser = mapper.Map<User, UserDTO>(_user);
            return convertUser;
        }
    }
}
