using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public interface IEventBL
    {
        Task<List<EventDTO>> GetAllEvents();
        Task<EventDTO> GetEventById(int id);
        Task AddEvent(EventDTO _event);
        Task DeleteEvent(int id);
        Task UpdateEvent(int id, EventDTO _event);


    }
}
