using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public interface IUserBL
    {
        Task<List<UserDTO>> GetAllUsers();
        Task<UserDTO> GetUserById(int id);
        Task AddUser(UserDTO user);
        Task DeleteUser(int id);
        Task UpdateUser(int id, UserDTO user);

    }
}
