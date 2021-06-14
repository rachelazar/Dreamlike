using DreamLikeDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public interface IEventDAL
    {
        Task AddEvent(Event _event);
        Task DeleteEvent(int id);
        Task<Event> GetEventById(int id);
        Task<List<Event>> GetAllEvents();
        Task UpdateEvent(int id, Event _event);
    }
}
