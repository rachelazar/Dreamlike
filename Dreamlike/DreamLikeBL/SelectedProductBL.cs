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
    public class SelectedProductBL : ISelectedProductBL
    {
        ISelectedProductDAL selectedProductDal;
        IMapper mapper;
        public SelectedProductBL(ISelectedProductDAL _selectedProductDal)
        {
            selectedProductDal = _selectedProductDal;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }

        public async Task AddSelectedProduct(SelectedProductDTO selectedProduct)
        {
            var _selectedProduct = mapper.Map<SelectedProductDTO, SelectedProduct>(selectedProduct);
            await selectedProductDal.AddSelectedProduct(_selectedProduct);
        }

        public async Task DeleteSelectedProduct(int id)
        {
            await selectedProductDal.DeleteSelectedProduct(id);
        }

        public async Task<SelectedProductDTO> GetSelectedProductById(int id)
        {
            SelectedProduct _selectedProduct = await selectedProductDal.GetSelectedProductById(id);
            var convertSelectedProduct = mapper.Map<SelectedProduct, SelectedProductDTO>(_selectedProduct);
            return convertSelectedProduct;
        }

        public async Task<List<SelectedProductDTO>> GetAllSelectedProducts()
        {
            List<SelectedProduct> listSelectedProducts = await selectedProductDal.GetAllSelectedProducts();
            var _selectedProduct = mapper.Map<List<SelectedProduct>, List<SelectedProductDTO>>(listSelectedProducts);
            return _selectedProduct;
        }

        public async Task UpdateSelectedProduct(int id, SelectedProductDTO selectedProduct)
        {
            var _selectedProduct = mapper.Map<SelectedProductDTO, SelectedProduct>(selectedProduct);
            await selectedProductDal.UpdateSelectedProduct(id, _selectedProduct);
        }
    }
}
