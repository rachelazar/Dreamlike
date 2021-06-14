using DreamLikeDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public interface ICouponDAL
    {
        Task AddCoupon(Coupon coupon);
        Task UpdateCoupon(int id, Coupon coupon);
        Task<List<Coupon>> GetAllCoupons();
        Task<Coupon> GetCouponById(int id);
        Task DeleteCoupon(int id);
    }
}
