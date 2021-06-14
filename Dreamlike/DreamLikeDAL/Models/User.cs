using System;
using System.Collections.Generic;

#nullable disable

namespace DreamLikeDAL.Models
{
    public partial class User
    {
        public User()
        {
            Coupons = new HashSet<Coupon>();
        }

        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellPhone { get; set; }
        public string Landline { get; set; }
        public string Mail { get; set; }
        public string Sms { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Coupon> Coupons { get; set; }
    }
}
