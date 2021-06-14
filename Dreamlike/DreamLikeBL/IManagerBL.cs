using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public interface IManagerBL
    {
        Task<List<ManagerDTO>> GetAllManagers();
        Task<ManagerDTO> GetManagerById(int id);
        Task AddManager(ManagerDTO manager);
        Task DeleteManager(int id);
        Task UpdateManager(int id, ManagerDTO manager);

       
    }
}
