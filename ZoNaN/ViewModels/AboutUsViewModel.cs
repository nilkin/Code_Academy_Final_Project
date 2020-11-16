using System.Collections.Generic;
using ZoNaN.Data.Models;
using ZoNaN.Models;

namespace ZoNaN.ViewModels
{
    public class AboutUsViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public AboutUs AboutUs { get; set; }
        public List<AboutUs> Abouts { get; set; }
        public Subscriber Subscriber { get; set; } 

    }
}
