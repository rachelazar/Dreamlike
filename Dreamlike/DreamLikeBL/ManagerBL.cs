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
    public class ManagerBL : IManagerBL
    {
        IManagerDAL managerDal;
        IMapper mapper;
        public ManagerBL(IManagerDAL _managerDal)
        {
            managerDal = _managerDal;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }

        public async Task AddManager(ManagerDTO manager)
        {
            var _manager = mapper.Map<ManagerDTO, Manager>(manager);
            await managerDal.AddManager(_manager);
        }

        public async Task DeleteManager(int id)
        {
            await managerDal.DeleteManager(id);
        }

        public async Task<ManagerDTO> GetManagerById(int id)
        {
            Manager _manager = await managerDal.GetManagerById(id);
            var convertManager = mapper.Map<Manager, ManagerDTO>(_manager);
            return convertManager;
        }

        public async Task<List<ManagerDTO>> GetAllManagers()
        {
            List<Manager> listManagers = await managerDal.GetAllManagers();
            var _manager = mapper.Map<List<Manager>, List<ManagerDTO>>(listManagers);
            return _manager;
        }

        public async Task UpdateManager(int id, ManagerDTO manager)
        {
            var _manager = mapper.Map<ManagerDTO, Manager>(manager);
            await managerDal.UpdateManager(id, _manager);
        }

    }
}
