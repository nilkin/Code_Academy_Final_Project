using System.Collections.Generic;
using ZoNaN.Data.Models;
using ZoNaN.Models;

namespace ZoNaN.ViewModels
{
    public class BlogGridViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public List<Blog> Blogs { get; set; }
        public Subscriber Subscriber { get; set; }
    }
}
