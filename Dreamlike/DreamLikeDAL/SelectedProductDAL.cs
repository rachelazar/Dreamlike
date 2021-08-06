using DreamLikeDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public class SelectedProductDAL : ISelectedProductDAL
    {
        DreamlikeContext _contextDB;
        public SelectedProductDAL(DreamlikeContext contextDB)
        {
            _contextDB = contextDB;
        }
        public async Task AddSelectedProduct(SelectedProduct selectedProduct)
        {
            try
            {
                await _contextDB.SelectedProduct.AddAsync(selectedProduct);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteSelectedProduct(int id)
        {
            try
            {
                var SelectedProductToDelete = await _contextDB.SelectedProduct.Where(i => i.ProductId == id).FirstOrDefaultAsync();
                _contextDB.Remove(SelectedProductToDelete);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<SelectedProduct>> GetAllSelectedProducts()
        {
            try
            {
                return await _contextDB.SelectedProduct.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<SelectedProduct> GetSelectedProductById(int id)
        {
            try
            {
                var SelectedProduct = await _contextDB.SelectedProduct.Where(a => a.ProductId == id).FirstOrDefaultAsync();
                return SelectedProduct;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateSelectedProduct(int id, SelectedProduct selectedProduct)
        {
            try
            {
                var SelectedProductToUpdate = _contextDB.SelectedProduct.SingleOrDefault(a => a.ProductId == id);
                SelectedProductToUpdate.ProductId = selectedProduct.ProductId;
                SelectedProductToUpdate.CouponId = selectedProduct.CouponId;
                SelectedProductToUpdate.Date = selectedProduct.Date;
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
