using DreamLikeDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeDAL
{
    public interface ISelectedProductDAL
    {
        Task AddSelectedProduct(SelectedProduct selectedProduct);
        Task DeleteSelectedProduct(int id);
        Task<SelectedProduct> GetSelectedProductById(int id);
        Task<List<SelectedProduct>> GetAllSelectedProducts();
        Task UpdateSelectedProduct(int id, SelectedProduct selectedProduct);
    }
}
