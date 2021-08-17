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
    public class EventController : ControllerBase
    {
        IEventBL _eventBL;
        public EventController(IEventBL eventBl)
        {
            _eventBL = eventBl;
        }

        [HttpGet]
        public async Task<ActionResult<List<EventDTO>>> GetAllEvents()
        {
            var eventData = await _eventBL.GetAllEvents();
            if (eventData == null)
            {
                return NoContent();

            }
            return Ok(eventData);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<EventDTO>>> GetEventById(int id)
        {
            var eventData = await _eventBL.GetEventById(id);
            if (eventData == null)
            {
                return NoContent();

            }
            return Ok(eventData);
        }

        [HttpPost]
        public async Task AddEvent([FromBody] EventDTO _event)
        {
            await _eventBL.AddEvent(_event);
        }

        [HttpDelete("{id}")]
        public async Task DeleteEvent([FromRoute] int id)
        {
            await _eventBL.DeleteEvent(id);
        }
    }
}
