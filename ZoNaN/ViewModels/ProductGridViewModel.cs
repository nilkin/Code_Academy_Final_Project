using ReflectionIT.Mvc.Paging;
using System.Collections.Generic;
using ZoNaN.Data.Models;
using ZoNaN.Models;

namespace ZoNaN.ViewModels
{
    public class ProductGridViewModel
    {
        public Breadcrumb Breadcrumb { get; set; } 
        public Subscriber Subscriber { get; set; }
        public List<Product> ProductsCount { get; set; }
        public PagingList<Product> PagingList { get; internal set; }
        public List<Category> Categories { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
