using DreamLikeDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public class CouponDAL : ICouponDAL
    {
        DreamlikeContext _contextDB;
        public CouponDAL(DreamlikeContext contextDB)
        {
            _contextDB = contextDB;
        }

        public async Task AddCoupon(Coupon coupon)
        {
            try
            {
                await _contextDB.Coupons.AddAsync(coupon);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteCoupon(int id)
        {
            try
            {
                var couponToDelete = await _contextDB.Coupons.Where(i => i.CouponId == id).FirstOrDefaultAsync();
                _contextDB.Coupons.Remove(couponToDelete);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Coupon>> GetAllCoupons()
        {
            try
            {
                return await _contextDB.Coupons.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Coupon> GetCouponById(int id)
        {
            try
            {
                var coupon = await _contextDB.Coupons.Where(a => a.CouponId == id).FirstOrDefaultAsync();
                return coupon;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateCoupon(int id, Coupon coupon)
        {
            try
            {
                var couponToUpdate = _contextDB.Coupons.SingleOrDefault(a => a.CouponId == id);
                couponToUpdate.CouponId = coupon.CouponId;
                couponToUpdate.RecipientName = coupon.RecipientName;
                couponToUpdate.GreetingCard = coupon.GreetingCard;
                couponToUpdate.MusicFile = coupon.MusicFile;
                couponToUpdate.TotalSum = coupon.TotalSum;
                couponToUpdate.ShippingAddress = coupon.ShippingAddress;
                couponToUpdate.DateOrder = coupon.DateOrder;
                couponToUpdate.Balance = coupon.Balance;
                couponToUpdate.UserId = coupon.UserId;
                couponToUpdate.EventId = coupon.EventId;

                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
