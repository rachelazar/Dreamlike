using DreamLikeDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public interface IManagerDAL
    {
        Task AddManager(Manager manager);
        Task DeleteManager(int id);
        Task<Manager> GetManagerById(int id);
        Task<List<Manager>> GetAllManagers();
        Task UpdateManager(int id, Manager manager);
    }
}
