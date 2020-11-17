using System.Collections.Generic;
using ZoNaN.Data.Models;
using ZoNaN.Models;

namespace ZoNaN.ViewModels
{
    public class CompareViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public List<Basket> CompareProducts { get; set; }
        public Subscriber Subscriber { get; set; }
    }
}
