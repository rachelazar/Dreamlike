using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLikeDTO
{
    public class CouponDTO
    {
        public int CouponId { get; set; }
        public string RecipientName { get; set; }
        public string GreetingCard { get; set; }
        public string MusicFile { get; set; }
        public double TotalSum { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime DateOrder { get; set; }
        public double Balance { get; set; }
        public string UserId { get; set; }
        public int EventId { get; set; }
    }
}
