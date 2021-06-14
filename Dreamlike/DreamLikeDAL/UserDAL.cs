﻿using DreamLikeDAL.Models;
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
        DreamLikeContext _contextDB;
        public UserDAL(DreamLikeContext contextDB)
        {
            _contextDB = contextDB;
        }
        public async Task AddUser(User user)
        {
            try
            {
                await _contextDB.Users.AddAsync(user);
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
                var UserToDelete = await _contextDB.Users.Where(i => i.UserId == id).FirstOrDefaultAsync();
                _contextDB.Users.Remove(UserToDelete);
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
                return await _contextDB.Users.ToListAsync();
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
                var user = await _contextDB.Users.Where(a => a.UserId == id).FirstOrDefaultAsync();
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
                var userToUpdate = _contextDB.Users.SingleOrDefault(a => a.UserId == id);
                userToUpdate.Username = user.Username;
                userToUpdate.FirstName = user.FirstName;
                userToUpdate.LastName = user.LastName;
                userToUpdate.CellPhone = user.CellPhone;
                userToUpdate.Landline = user.Landline;
                userToUpdate.Mail = user.Mail;
                userToUpdate.Sms = user.Sms;
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
