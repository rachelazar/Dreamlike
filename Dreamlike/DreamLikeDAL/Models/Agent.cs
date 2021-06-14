using System;
using System.Collections.Generic;

#nullable disable

namespace DreamLikeDAL.Models
{
    public partial class Agent
    {
        public int AgentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MailAddress { get; set; }
        public string BusinessName { get; set; }
    }
}
