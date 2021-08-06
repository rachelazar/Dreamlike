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
    public class SelectedProductController : ControllerBase
    {
        ISelectedProductBL _selectedProductBL;
        public SelectedProductController(ISelectedProductBL selectedProductBl)
        {
            _selectedProductBL = selectedProductBl;
        }
         
        [HttpGet]
        public async Task<ActionResult<List<SelectedProductDTO>>> GetAllSelectedProducts()
        {
            var selectedProductData = await _selectedProductBL.GetAllSelectedProducts();
            if (selectedProductData == null)
            {
                return NoContent();

            }
            return Ok(selectedProductData);
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<List<SelectedProductDTO>>> GetSelectedProductById(int id)
        {
            var selectedProductData = await _selectedProductBL.GetSelectedProductById(id);
            if (selectedProductData == null)
            {
                return NoContent();

            }
            return Ok(selectedProductData);
        }

        [HttpPost]
        public async Task AddSelectedProduct([FromBody] SelectedProductDTO selectedProduct)
        {
            await _selectedProductBL.AddSelectedProduct(selectedProduct);
        }

        [HttpDelete("{id}")]
        public async Task DeleteSelectedProduct([FromRoute] int id)
        {
            await _selectedProductBL.DeleteSelectedProduct(id);
        }
    }
}
