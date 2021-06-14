using DreamLikeDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public interface IAgentDAL
    {
        Task AddAgent(Agent agent);
        Task DeleteAgent(int id);
        Task<List<Agent>> GetAllAgents();
        Task<Agent> GetAgentById(int id);
        Task UpdateAgent(int id, Agent agent);
    }
}
