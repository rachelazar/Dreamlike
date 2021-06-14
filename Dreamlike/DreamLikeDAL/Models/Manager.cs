using System;
using System.Collections.Generic;

#nullable disable

namespace DreamLikeDAL.Models
{
    public partial class Manager
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int ManagerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MailAddress { get; set; }
    }
}
