using DreamLikeDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public interface IUserDAL
    {
        Task AddUser(User user);
        Task DeleteUser(int id);
        Task<User> GetUserById(int id);
        Task<List<User>> GetAllUsers();
        Task UpdateUser(int id, User user);
    }
}
