using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public interface ICouponBL
    {
       
        Task<List<CouponDTO>> GetAllCoupons();
        Task<CouponDTO> GetCouponById(int id);
        Task AddCoupon(CouponDTO coupon);
        Task DeleteCoupon(int id);
        Task UpdateCoupon(int id, CouponDTO coupon);
    }
}
