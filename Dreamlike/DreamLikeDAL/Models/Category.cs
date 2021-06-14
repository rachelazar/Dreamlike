using System;
using System.Collections.Generic;

#nullable disable

namespace DreamLikeDAL.Models
{
    public partial class Category
    {
        public Category()
        {
            BlockedCategories = new HashSet<BlockedCategory>();
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<BlockedCategory> BlockedCategories { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
