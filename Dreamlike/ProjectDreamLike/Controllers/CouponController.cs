using DreamLikeBL;
using DreamLikeDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamLike.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        ICouponBL _couponBL;
        public CouponController(ICouponBL couponBl)
        {
            _couponBL = couponBl;
        }

        [HttpGet]
        public async Task<ActionResult<List<CouponDTO>>> GetAllCoupons()
        {
            var couponData = await _couponBL.GetAllCoupons();
            if (couponData == null)
            {
                return NoContent();

            }
            return Ok(couponData);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<CouponDTO>>> GetCouponById(int id)
        {
            var couponData = await _couponBL.GetCouponById(id);
            if (couponData == null)
            {
                return NoContent();

            }
            return Ok(couponData);
        }

        [HttpPost]
        public async Task AddCoupon([FromBody] CouponDTO coupon)
        {
            await _couponBL.AddCoupon(coupon);
        }

        [HttpDelete("{id}")]
        public async Task DeleteCoupon([FromRoute] int id)
        {
            await _couponBL.DeleteCoupon(id);
        }
    }
}
