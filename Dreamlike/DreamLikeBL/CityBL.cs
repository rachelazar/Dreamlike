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
    public class CityBL : ICityBL
    {
        ICityDAL cityDal;
        IMapper mapper;

        public CityBL(ICityDAL _cityDal)
        {
            cityDal = _cityDal;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }

        public async Task AddCity(CityDTO city)
        {
            var _city = mapper.Map<CityDTO, City>(city);
            await cityDal.AddCity(_city);
        }

        public async Task DeleteCity(int id)
        {
            await cityDal.DeleteCity(id);
        }

        public async Task<CityDTO> GetCityById(int id)
        {
            City _city = await cityDal.GetCityById(id);
            var convertCity = mapper.Map<City, CityDTO>(_city);
            return convertCity;
        }

        public async Task<List<CityDTO>> GetAllCities()
        {
            List<City> listCitys = await cityDal.GetAllCities();
            var _city = mapper.Map<List<City>, List<CityDTO>>(listCitys);
            return _city;
        }

        public async Task UpdateCity(int id, CityDTO city)
        {
            var _city = mapper.Map<CityDTO, City>(city);
            await cityDal.UpdateCity(id, _city);
        }
    }
}
