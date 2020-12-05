using ZoNaN.Data.Models;
using ZoNaN.Models;

namespace ZoNaN.ViewModels
{
    public class BlogSingleViewModel
    {
        public Breadcrumb Breadcrumb { get; set; }
        public Blog SingleBlog { get; set; }
        public Subscriber Subscriber { get; set; }
        public Comment Comment { get; set; }
    }
}
