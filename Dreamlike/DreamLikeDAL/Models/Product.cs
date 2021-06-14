using System;
using System.Collections.Generic;

#nullable disable

namespace DreamLikeDAL.Models
{
    public partial class Product
    {
        public Product()
        {
            SelectedProducts = new HashSet<SelectedProduct>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<SelectedProduct> SelectedProducts { get; set; }
    }
}
