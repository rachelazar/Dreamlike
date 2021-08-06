using DreamLikeBL;
using DreamLikeDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamLike.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        ICityBL _cityBL;
        public CityController(ICityBL cityBl)
        {
            _cityBL = cityBl;
        }

        [HttpGet]
        public async Task<ActionResult<List<CityDTO>>> GetAllCitys()
        {
            var cityData = await _cityBL.GetAllCities();
            if (cityData == null)
            {
                return NoContent();

            }
            return Ok(cityData);
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<List<CityDTO>>> GetCityById(int id)
        {
            var cityData = await _cityBL.GetCityById(id);
            if (cityData == null)
            {
                return NoContent();

            }
            return Ok(cityData);
        }

        [HttpPost]
        public async Task AddCity([FromBody] CityDTO city)
        {
            await _cityBL.AddCity(city);
        }

        [HttpDelete("{id}")]
        public async Task DeleteCity([FromRoute] int id)
        {
            await _cityBL.DeleteCity(id);
        }
    }
}
