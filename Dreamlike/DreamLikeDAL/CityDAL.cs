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
        DreamLikeContext _contextDB;
        public CityDAL(DreamLikeContext contextDB)
        {
            _contextDB = contextDB;
        }
        public async Task AddCity(City city)
        {
            try
            {
                await _contextDB.Cities.AddAsync(city);
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
                var cityToDelete = await _contextDB.Cities.Where(i => i.CityId == id).FirstOrDefaultAsync();
                _contextDB.Cities.Remove(cityToDelete);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<City>> GetAllCitys()
        {
            try
            {
                return await _contextDB.Cities.ToListAsync();
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
                var city = await _contextDB.Cities.Where(a => a.CityId == id).FirstOrDefaultAsync();
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
                var cityToUpdate = _contextDB.Cities.SingleOrDefault(a => a.CityId == id);
                cityToUpdate.CityId = city.CityId;
                cityToUpdate.Name = city.Name;
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
