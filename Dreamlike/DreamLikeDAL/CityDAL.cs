using DreamLikeDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public class CityDAL : ICityDAL
    {
        DreamlikeContext _contextDB;
        public CityDAL(DreamlikeContext contextDB)
        {
            _contextDB = contextDB;
        }
        public async Task AddCity(City city)
        {
            try
            {
                await _contextDB.City.AddAsync(city);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteCity(int id)
        {
            try
            {
                var cityToDelete = await _contextDB.City.Where(i => i.CityId == id).FirstOrDefaultAsync();
                _contextDB.City.Remove(cityToDelete);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<City>> GetAllCities()
        {
            try
            {
                return await _contextDB.City.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<City> GetCityById(int id)
        {
            try
            {
                var city = await _contextDB.City.Where(a => a.CityId == id).FirstOrDefaultAsync();
                return city;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateCity(int id, City city)
        {
            try
            {
                var cityToUpdate = _contextDB.City.SingleOrDefault(a => a.CityId == id);
                cityToUpdate.CityId = city.CityId;
                cityToUpdate.CityName = city.CityName;
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
