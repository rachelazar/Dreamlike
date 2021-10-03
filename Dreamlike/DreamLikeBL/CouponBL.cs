using AutoMapper;
using DreamLikeDAL;
using DreamLikeDAL.Models;
using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public class CouponBL : ICouponBL
    {
        ICouponDAL couponDal;
        IMapper mapper;
        IMailBL mailBL;
        public CouponBL(ICouponDAL _couponDal)
        {
            couponDal = _couponDal;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }

        public async Task AddCoupon(CouponDTO coupon)
        {
            var _coupon = mapper.Map<CouponDTO, Coupon>(coupon);
            mailBL.SendMailAsync(""+_coupon.CouponId, "dreamlike wish you happy holiday", "t0548561711@gmail.com");
            await couponDal.AddCoupon(_coupon);
        }

        public async Task DeleteCoupon(int id)
        {
            await couponDal.DeleteCoupon(id);
        }

        public async Task<CouponDTO> GetCouponById(int id)
        {
            Coupon _coupon = await couponDal.GetCouponById(id);
            var convertCoupon = mapper.Map<Coupon, CouponDTO>(_coupon);
            return convertCoupon;
        }

        public async Task<List<CouponDTO>> GetAllCoupons()
        {
            List<Coupon> listCoupons = await couponDal.GetAllCoupons();
            var _coupon = mapper.Map<List<Coupon>, List<CouponDTO>>(listCoupons);
            return _coupon;
        }

        public async Task UpdateCoupon(int id, CouponDTO coupon)
        {
            var _coupon = mapper.Map<CouponDTO, Coupon>(coupon);
            await couponDal.UpdateCoupon(id, _coupon);
        }

       
    }
}
