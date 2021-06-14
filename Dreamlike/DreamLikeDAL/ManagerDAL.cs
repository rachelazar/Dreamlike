using DreamLikeDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public class ManagerDAL : IManagerDAL
    {
        DreamLikeContext _contextDB;
        public ManagerDAL(DreamLikeContext contextDB)
        {
            _contextDB = contextDB;
        }
        public async Task AddManager(Manager manager)
        {
            try
            {
                await _contextDB.Managers.AddAsync(manager);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteManager(int id)
        {
            try
            {
                var managerToDelete = await _contextDB.Managers.Where(i => i.ManagerId == id).FirstOrDefaultAsync();
                _contextDB.Managers.Remove(managerToDelete);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Manager>> GetAllManagers()
        {
            try
            {
                return await _contextDB.Managers.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Manager> GetManagerById(int id)
        {
            try
            {
                var manager = await _contextDB.Managers.Where(a => a.ManagerId == id).FirstOrDefaultAsync();
                return manager;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task UpdateManager(int id, Manager manager)
        {
                try
                {
                    var managerToUpdate = _contextDB.Managers.SingleOrDefault(a => a.ManagerId == id);
                    managerToUpdate.Username = manager.Username;
                    managerToUpdate.Password = manager.Password;
                    managerToUpdate.ManagerId = manager.ManagerId;
                    managerToUpdate.Name = manager.Name;
                    managerToUpdate.Address = manager.Address;
                    managerToUpdate.Phone = manager.Phone;
                    managerToUpdate.MailAddress = manager.MailAddress;


                    await _contextDB.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }
    }
}
