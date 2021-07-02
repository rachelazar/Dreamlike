using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public interface ILoginBL
    {
        Task<UserDTO> Login(LoginDTO login);
    }
}
