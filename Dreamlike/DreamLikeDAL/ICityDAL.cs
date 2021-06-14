using DreamLikeDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public interface ICityDAL
    {
        Task<List<City>> GetAllCitys();
        Task UpdateCity(int id, City city);
        Task<City> GetCityById(int id);
        Task DeleteCity(int id);
        Task AddCity(City city);
    }
}
