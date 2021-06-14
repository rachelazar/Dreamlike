using AutoMapper;
using DreamLikeDAL;
using DreamLikeDTO;
using DreamLikeDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public class AgentBL : IAgentBL
    {
        IAgentDAL agentDal;
        IMapper mapper;

        public AgentBL(IAgentDAL _agentDal)
        {
            agentDal = _agentDal;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }

        public async Task AddAgent(AgentDTO agent)
        {
            var _agent = mapper.Map<AgentDTO, Agent>(agent);
            await agentDal.AddAgent(_agent);
        }

        public async Task DeleteAgent(int id)
        {
            await agentDal.DeleteAgent(id);
        }

        public async Task<AgentDTO> GetAgentById(int id)
        {
            Agent _agent = await agentDal.GetAgentById(id);
            var convertAgent = mapper.Map<Agent, AgentDTO>(_agent);
            return convertAgent;
        }

        public async Task<List<AgentDTO>> GetAllAgents()
        {
            List<Agent> listAgents = await agentDal.GetAllAgents();
            var _agent = mapper.Map<List<Agent>, List<AgentDTO>>(listAgents);
            return _agent;
        }

        public async Task UpdateAgent(int id, AgentDTO agent)
        {
            var _agent = mapper.Map<AgentDTO, Agent>(agent);
            await agentDal.UpdateAgent(id, _agent);
        }
    }
}
