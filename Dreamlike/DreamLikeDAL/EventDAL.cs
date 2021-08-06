using DreamLikeDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public class EventDAL : IEventDAL
    {
        DreamlikeContext _contextDB;
        public EventDAL(DreamlikeContext contextDB)
        {
            _contextDB = contextDB;
        }
        public async Task AddEvent(Event _event)
        {
            try
            {
                await _contextDB.Event.AddAsync(_event);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteEvent(int id)
        {
            try
            {
                var eventToDelete = await _contextDB.Event.Where(i => i.EventId == id).FirstOrDefaultAsync();
                _contextDB.Event.Remove(eventToDelete);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Event>> GetAllEvents()
        {
            try
            {
                return await _contextDB.Event.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Event> GetEventById(int id)
        {
            try
            {
                var _event = await _contextDB.Event.Where(a => a.EventId == id).FirstOrDefaultAsync();
                return _event;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateEvent(int id, Event _event)
        {
            try
            {
                var eventToUpdate = _contextDB.Event.SingleOrDefault(a => a.EventId == id);
                eventToUpdate.EventId = _event.EventId;
                eventToUpdate.Type = _event.Type;
                

                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
