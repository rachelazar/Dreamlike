using AutoMapper;
using DreamLikeDAL;
using DreamLikeDAL.Models;
using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public class LoginBL : ILoginBL
    {
        ILoginDAL loginDal;
        IMailBL mailBL;
        public LoginBL(ILoginDAL loginDal, IMailBL mailBL)
        {
            this.loginDal = loginDal;
            this.mailBL = mailBL;
        }

        public async Task<int?> Login(LoginDTO login)
        {
            //if (login.Username == )
            mailBL.SendMailAsync("hey", "dreamlike wish you happy holiday", login.Username);
            return await loginDal.Login(login.Username, login.Password);
        }
    }
}
