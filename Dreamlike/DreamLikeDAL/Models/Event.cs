using System;
using System.Collections.Generic;

#nullable disable

namespace DreamLikeDAL.Models
{
    public partial class Event
    {
        public Event()
        {
            Coupons = new HashSet<Coupon>();
        }

        public int EventId { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Coupon> Coupons { get; set; }
    }
}
