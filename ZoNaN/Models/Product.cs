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
        public int SubCategoryId { get; set; }
        public int DetailId { get; set; }
        public int Discount { get; set; }
        public bool IsBestSel { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsNew { get; set; }
        public int Star { get; set; }
        public int ColorId { get; set; }
        public int DimensionId { get; set; }
        public int SizeId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public SubCategory SubCategory { get; set; }
        public Color Color { get; set; }
        public Dimension Dimension{ get; set; }
        public Size Size { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<ProductPhoto> Photos { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
