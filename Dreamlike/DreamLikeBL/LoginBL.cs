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
        //******
        IUserBL userBL;
        public LoginBL(ILoginDAL loginDal, IMailBL mailBL, IUserBL userBL)
        {
            this.loginDal = loginDal;
            this.mailBL = mailBL;
            //******
            this.userBL = userBL;
        }

        public async Task<int?> Login(LoginDTO login)
        {
            ////******
            ////if()
            ////if (login.Username == )
            //try
            //{
            //    mailBL.SendMailAsync("hey", "dreamlike wish you happy holiday", login.Username);
            //    return await loginDal.Login(login.Username, login.Password);
            //}
            //catch (Exception e)
            //{
            //    throw e;
            //    return 0;
            //}
            if (IsValidEmail(login.Username))
            {
                mailBL.SendMailAsync("hey", "dreamlike wish you happy holiday", login.Username);
                return await loginDal.Login(login.Username, login.Password);
            }
            return 0;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
