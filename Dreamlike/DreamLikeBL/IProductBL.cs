using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public interface IProductBL
    {
        Task<List<ProductDTO>> GetAllProducts();
        Task<ProductDTO> GetProductById(int id);
        Task AddProduct(ProductDTO product);
        Task DeleteProduct(int id);
        Task UpdateProduct(int id, ProductDTO product);
    }
}
