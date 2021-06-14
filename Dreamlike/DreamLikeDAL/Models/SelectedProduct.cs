using System;
using System.Collections.Generic;

#nullable disable

namespace DreamLikeDAL.Models
{
    public partial class SelectedProduct
    {
        public int ProductId { get; set; }
        public int CouponId { get; set; }
        public DateTime Date { get; set; }

        public virtual Coupon Coupon { get; set; }
        public virtual Product Product { get; set; }
    }
}
