using System.Collections.Generic;
using ZoNaN.Data.Models;
using ZoNaN.Models;

namespace ZoNaN.ViewModels
{
    public class HomeViewModel
    {
        public List<Banner> MainBanners { get; set; }
        public List<Banner> PromoBanners { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> BestSelProducts { get; set; }
        public List<Product> FeaturedProducts { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Product> NewProducts { get; set; }
        public Banner DiscountBanner { get; set; }
        public List<Blog> NewBlogs { get; set; }
        public Subscriber Subscriber { get; set; }

    }
}
