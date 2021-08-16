using DreamLikeDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public class UserDAL : IUserDAL
    {
        DreamlikeContext _contextDB;
        public UserDAL(DreamlikeContext contextDB)
        {
            _contextDB = contextDB;
        }
        public async Task AddUser(User user)
        {
            try
            {
                await _contextDB.User.AddAsync(user);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteUser(int id)
        {
            try
            {
                var UserToDelete = await _contextDB.User.Where(i => i.UserId.Equals(id)).FirstOrDefaultAsync();
                _contextDB.User.Remove(UserToDelete);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                return await _contextDB.User.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> GetUserById(int id)
        {
            try
            {
                var user = await _contextDB.User.Where(a => a.UserId.Equals(id)).FirstOrDefaultAsync();
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateUser(int id, User user)
        {
            try
            {
                var userToUpdate = _contextDB.User.SingleOrDefault(a => a.UserId.Equals(id));
                userToUpdate.Username = user.Username;
                userToUpdate.FirstName = user.FirstName;
                userToUpdate.LastName = user.LastName;
                userToUpdate.Mail = user.Mail;
                userToUpdate.Phone = user.Phone;
                userToUpdate.Username = user.Username;
                userToUpdate.Password = user.Password;
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
