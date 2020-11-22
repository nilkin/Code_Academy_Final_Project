using System.Collections.Generic;
using ZoNaN.Data;
using ZoNaN.Data.Models;
using ZoNaN.Models;

namespace ZoNaN.ViewModels
{
    public class WishViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public Subscriber Subscriber { get; set; }
        public List<BasketItem> WishItems { get; set; }

    }
}
