//using DreamLikeDAL.Models;
using DreamLikeDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public class LoginDAL : ILoginDAL
    {
        DreamlikeContext _contextDB;
        public async Task<User> Login(string username, string password)
        {
            try
            {
                var userLogin = await _contextDB.User.Where(u => u.Username == username && u.Password == password).FirstOrDefaultAsync();
                return userLogin;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
