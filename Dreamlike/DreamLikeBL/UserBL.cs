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
    public class UserBL : IUserBL
    {
        IUserDAL userDal;
        IMapper mapper;
        public UserBL(IUserDAL _userDal)
        {
            userDal = _userDal;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }

        public async Task AddUser(UserDTO user)
        {
            var _user = mapper.Map<UserDTO, User>(user);
            await userDal.AddUser(_user);
        }

        public async Task DeleteUser(int id)
        {
            await userDal.DeleteUser(id);
        }

        public async Task<UserDTO> GetUserById(int id)
        {
            User _user = await userDal.GetUserById(id);
            var convertUser = mapper.Map<User, UserDTO>(_user);
            return convertUser;
        }

        public async Task<List<UserDTO>> GetAllUsers()
        {
            List<User> listUsers = await userDal.GetAllUsers();
            var _user = mapper.Map<List<User>, List<UserDTO>>(listUsers);
            return _user;
        }

        public async Task UpdateUser(int id, UserDTO user)
        {
            var _user = mapper.Map<UserDTO, User>(user);
            await userDal.UpdateUser(id, _user);
        }
    }
}
