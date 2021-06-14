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
    public class EventBL : IEventBL
    {
        IEventDAL eventDal;
        IMapper mapper;
        public EventBL(IEventDAL _eventDal)
        {
            eventDal = _eventDal;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }

        public async Task AddEvent(EventDTO Event)
        {
            var _event = mapper.Map<EventDTO, Event>(Event);
            await eventDal.AddEvent(_event);
        }

        public async Task DeleteEvent(int id)
        {
            await eventDal.DeleteEvent(id);
        }

        public async Task<EventDTO> GetEventById(int id)
        {
            Event _event = await eventDal.GetEventById(id);
            var convertEvent = mapper.Map<Event, EventDTO>(_event);
            return convertEvent;
        }

        public async Task<List<EventDTO>> GetAllEvents()
        {
            List<Event> listEvents = await eventDal.GetAllEvents();
            var _event = mapper.Map<List<Event>, List<EventDTO>>(listEvents);
            return _event;
        }

        public async Task UpdateEvent(int id, EventDTO Event)
        {
            var _event = mapper.Map<EventDTO, Event>(Event);
            await eventDal.UpdateEvent(id, _event);
        }
    }
}
