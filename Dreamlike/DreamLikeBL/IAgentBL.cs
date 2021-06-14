using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public interface IAgentBL
    {
        Task<List<AgentDTO>> GetAllAgents();
        Task<AgentDTO> GetAgentById(int id);
        Task AddAgent(AgentDTO agent);
        Task DeleteAgent(int id);
        Task UpdateAgent(int id, AgentDTO agent);
    }
}
