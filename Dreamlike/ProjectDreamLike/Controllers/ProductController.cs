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
    public class ProductController : ControllerBase
    {
        IProductBL _productBL;
        public ProductController(IProductBL productBl)
        {
            _productBL = productBl;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDTO>>> GetAllProducts()
        {
            var productData = await _productBL.GetAllProducts();
            if (productData == null)
            {
                return NoContent();

            }
            return Ok(productData);
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<List<ProductDTO>>> GetProductById(int id)
        {
            var productData = await _productBL.GetProductById(id);
            if (productData == null)
            {
                return NoContent();

            }
            return Ok(productData);
        }

        [HttpPost]
        public async Task AddProduct([FromBody] ProductDTO product)
        {
            await _productBL.AddProduct(product);
        }

        [HttpDelete("{id}")]
        public async Task DeleteProduct([FromRoute] int id)
        {
            await _productBL.DeleteProduct(id);
        }
    }
}
