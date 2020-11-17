using System.Collections.Generic;
using ZoNaN.Data.Models;
using ZoNaN.Models;

namespace ZoNaN.ViewModels
{
    public class ProductSingleViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public Subscriber Subscriber { get; set; }
        public Product ProductSingle { get; set; }
        public List<Product> LikeProducts { get; set; }
        public List<Product> SameCategoryProducts { get; set; }
    }
}
