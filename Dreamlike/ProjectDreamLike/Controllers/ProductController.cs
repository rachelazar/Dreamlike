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

        //[HttpGet]
        public async Task<ActionResult<List<ProductDTO>>> GetAllProducts()
        {
            var productData = await _productBL.GetAllProducts();
            if (productData == null)
            {
                return NoContent();
            }
            return Ok(productData);
        }

        //[Route("[action]")]
        [HttpGet("{id}")]
        public async Task<ProductDTO> GetProductById([FromRoute] int id)
        {
            var productData = await _productBL.GetProductById(id);
            //if (productData == null)
            //{
            //    return NoContent();

            //}
            //return Ok(productData);
            return productData;
        }

        //[HttpGet("{name}")]
        [Route("[action]")]
        public async Task<List<ProductDTO>> GetProductByName([FromRoute] string name)
        {
            var productData = await _productBL.GetProductByName(name);
            //if (productData == null)
            //{
            //    return NoContent();

            //}
            //return Ok(productData);
            return productData;
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