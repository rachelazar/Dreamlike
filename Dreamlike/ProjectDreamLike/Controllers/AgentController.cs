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
    public class AgentController : ControllerBase
    {
        IAgentBL _agentBL;
        public AgentController(IAgentBL agentBL)
        {
            _agentBL = agentBL;
        }

        [HttpGet]
        public async Task<ActionResult<List<AgentDTO>>> GetAllAgents()
        {
            var agentData = await _agentBL.GetAllAgents();
            if (agentData == null)
            {
                return NoContent();

            }
            return Ok(agentData);
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<List<AgentDTO>>> GetAgentById(int id)
        {
            var agentData = await _agentBL.GetAgentById(id);
            if (agentData == null)
            {
                return NoContent();

            }
            return Ok(agentData);
        }

        [HttpPost]
        public async Task AddAgent([FromBody] AgentDTO agent)
        {
            await _agentBL.AddAgent(agent);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAgent([FromRoute] int id)
        {
            await _agentBL.DeleteAgent(id);
        }
    }
}
