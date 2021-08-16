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
        DreamlikeContext _contextDB;
        public ProductDAL(DreamlikeContext contextDB)
        {
            _contextDB = contextDB;
        }
        public async Task AddProduct(Product product)
        {
            try
            {
                await _contextDB.Product.AddAsync(product);
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
                var productToDelete = await _contextDB.Product.Where(i => i.ProductId == id).FirstOrDefaultAsync();
                _contextDB.Product.Remove(productToDelete);
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
                return await _contextDB.Product.ToListAsync();
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
                var product = await _contextDB.Product.Where(a => a.ProductId == id).FirstOrDefaultAsync();
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Product>> GetProductByName(string name)
        {
            try
            {
                var products = await _contextDB.Product.Where(a => a.Name.Contains(name.Trim())).ToListAsync();
                return products;
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
                var productToUpdate = _contextDB.Product.SingleOrDefault(a => a.ProductId == id);
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
