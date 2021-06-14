using AutoMapper;
using DreamLikeDAL;
using DreamLikeDAL.Models;
using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public class ProductBL : IProductBL
    {
        IProductDAL productDal;
        IMapper mapper;
        public ProductBL(IProductDAL _productDal)
        {
            productDal = _productDal;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }

        public async Task AddProduct(ProductDTO product)
        {
            var _product = mapper.Map<ProductDTO, Product>(product);
            await productDal.AddProduct(_product);
        }

        public async Task DeleteProduct(int id)
        {
            await productDal.DeleteProduct(id);
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            Product _product = await productDal.GetProductById(id);
            var convertProduct = mapper.Map<Product, ProductDTO>(_product);
            return convertProduct;
        }

        public async Task<List<ProductDTO>> GetAllProducts()
        {
            List<Product> listProducts = await productDal.GetAllProducts();
            var _product = mapper.Map<List<Product>, List<ProductDTO>>(listProducts);
            return _product;
        }

        public async Task UpdateProduct(int id, ProductDTO product)
        {
            var _product = mapper.Map<ProductDTO, Product>(product);
            await productDal.UpdateProduct(id, _product);
        }

    }
}
