using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoNaN.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
        public bool IsBestSel { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsNew { get; set; }
        public byte Star { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Dimension { get; set; }
        public string Size { get; set; }
        public int StockId { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public Stock Stock { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<ProductPhoto> ProductPhotos { get; set; }
        public ICollection<ProductBascet> ProductBascets { get; set; }
    }
}
