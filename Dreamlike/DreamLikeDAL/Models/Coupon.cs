using System;
using System.Collections.Generic;

#nullable disable

namespace DreamLikeDAL.Models
{
    public partial class Coupon
    {
        public Coupon()
        { 
            BlockedCategories = new HashSet<BlockedCategory>();
            SelectedProducts = new HashSet<SelectedProduct>();
        }

        public int CouponId { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public string RecipientName { get; set; }
        public string GreetingCard { get; set; }
        public string MusicFile { get; set; }
        public double TotalSum { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime DateOrder { get; set; }
        public double Balance { get; set; }

        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<BlockedCategory> BlockedCategories { get; set; }
        public virtual ICollection<SelectedProduct> SelectedProducts { get; set; }
    }
}
