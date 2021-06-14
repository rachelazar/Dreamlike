using DreamLikeDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public class ProductDAL : IProductDAL
    {
        DreamLikeContext _contextDB;
        public ProductDAL(DreamLikeContext contextDB)
        {
            _contextDB = contextDB;
        }
        public async Task AddProduct(Product product)
        {
            try
            {
                await _contextDB.Products.AddAsync(product);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteProduct(int id)
        {
            try
            {
                var productToDelete = await _contextDB.Products.Where(i => i.ProductId == id).FirstOrDefaultAsync();
                _contextDB.Products.Remove(productToDelete);
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Product>> GetAllProducts()
        {
            try
            {
                return await _contextDB.Products.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Product> GetProductById(int id)
        {
            try
            {
                var product = await _contextDB.Products.Where(a => a.ProductId == id).FirstOrDefaultAsync();
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateProduct(int id, Product product)
        {
            try
            {
                var productToUpdate = _contextDB.Products.SingleOrDefault(a => a.ProductId == id);
                productToUpdate.ProductId = product.ProductId;
                productToUpdate.Name = product.Name;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
                productToUpdate.CategoryId = product.CategoryId;
                await _contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
