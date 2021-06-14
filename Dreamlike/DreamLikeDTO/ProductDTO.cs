using System;
using System.Collections.Generic;
using System.Text;

namespace DreamLikeDTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}
