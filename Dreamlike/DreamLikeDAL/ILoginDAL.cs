using DreamLikeDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public interface ILoginDAL
    {
        Task<User> Login(string username, string password);
    }
}
