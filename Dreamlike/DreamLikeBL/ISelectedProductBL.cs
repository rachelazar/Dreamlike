using DreamLikeDTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public interface ISelectedProductBL
    {
        Task<List<SelectedProductDTO>> GetAllSelectedProducts();
        Task<SelectedProductDTO> GetSelectedProductById(int id);
        Task AddSelectedProduct(SelectedProductDTO selectedProduct);
        Task DeleteSelectedProduct(int id);
        Task UpdateSelectedProduct(int id, SelectedProductDTO selectedProduct);
    }
}
