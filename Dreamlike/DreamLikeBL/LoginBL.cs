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
       


        public async Task<int> Login(LoginDTO login)
        {
            int id = await loginDal.Login(login.Username, login.Password);
            
            return id;
        }
    }
}
