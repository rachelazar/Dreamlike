using System;
using System.Collections.Generic;

#nullable disable

namespace DreamLikeDAL.Models
{
    public partial class BlockedCategory
    {
        public int CategoryId { get; set; }
        public int CouponId { get; set; }
        public string Description { get; set; }
        public virtual Category Category { get; set; }
        public virtual Coupon Coupon { get; set; }
    }
}
