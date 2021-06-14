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
        DreamLikeContext _contextDB;
        public EventDAL(DreamLikeContext contextDB)
        {
            _contextDB = contextDB;
        }
        public async Task AddEvent(Event _event)
        {
            try
            {
                await _contextDB.Events.AddAsync(_event);
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
                var eventToDelete = await _contextDB.Events.Where(i => i.EventId == id).FirstOrDefaultAsync();
                _contextDB.Events.Remove(eventToDelete);
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
                return await _contextDB.Events.ToListAsync();
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
                var _event = await _contextDB.Events.Where(a => a.EventId == id).FirstOrDefaultAsync();
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
                var eventToUpdate = _contextDB.Events.SingleOrDefault(a => a.EventId == id);
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
