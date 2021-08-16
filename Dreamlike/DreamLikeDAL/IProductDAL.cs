using DreamLikeDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public interface IProductDAL
    {
        Task AddProduct(Product product);
        Task DeleteProduct(int id);
        Task<Product> GetProductById(int id);
        Task<List<Product>> GetProductByName(string name);
        Task<List<Product>> GetAllProducts();
        Task UpdateProduct(int id, Product product);
    }
}
