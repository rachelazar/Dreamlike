using DreamLikeDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public class AgentDAL : IAgentDAL
    {
        DreamlikeContext _contextDB;
        public AgentDAL(DreamlikeContext contextDB)
        {
            _contextDB = contextDB;
        }

        public async Task AddAgent(Agent agent)
        {
            try
            {
                await _contextDB.Agent.AddAsync(agent);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteAgent(int id)
        {
            try
            {
                var agentToDelete = await _contextDB.Agent.Where(i => i.AgentId == id).FirstOrDefaultAsync();
                _contextDB.Agent.Remove(agentToDelete);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Agent>> GetAllAgents()
        {
            try
            {
                return await _contextDB.Agent.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Agent> GetAgentById(int id)
        {
            try
            {
                var agent = await _contextDB.Agent.Where(a => a.AgentId == id).FirstOrDefaultAsync();
                return agent;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateAgent(int id, Agent agent)
        {
            try
            {
                var agentToUpdate = _contextDB.Agent.SingleOrDefault(a => a.AgentId == id);
                agentToUpdate.Name = agent.Name;
                agentToUpdate.Phone = agent.Phone;
                agentToUpdate.Address = agent.Address;
                agentToUpdate.Mail = agent.Mail;
                agentToUpdate.BusinessName = agent.BusinessName;
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
