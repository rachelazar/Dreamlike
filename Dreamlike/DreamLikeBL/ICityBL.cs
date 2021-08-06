using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public interface ICityBL
    {
        Task<List<CityDTO>> GetAllCities();
        Task<CityDTO> GetCityById(int id);
        Task AddCity(CityDTO city);
        Task DeleteCity(int id);
        Task UpdateCity(int id, CityDTO city);
    }
}
