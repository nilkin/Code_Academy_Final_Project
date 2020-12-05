using Microsoft.EntityFrameworkCore;
using ZoNaN.Data.Configuration;
using ZoNaN.Data.Models;
using ZoNaN.Models;

namespace ZoNaN.Data
{
    public class ZonanDbContext: DbContext
    {
        public ZonanDbContext(DbContextOptions<ZonanDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AboutUsConfiguration());
            builder.ApplyConfiguration(new BannerConfiguration());
            builder.ApplyConfiguration(new BreadcrumbConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new ContactUsConfiguration());
            builder.ApplyConfiguration(new ChekoutConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new BlogConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new SubCategoryConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new ProductPhotoConfiguration());
            builder.ApplyConfiguration(new SettingConfiguration());
            builder.ApplyConfiguration(new SocialLinkConfiguration());
            builder.ApplyConfiguration(new TestimonialConfiguration());
            builder.ApplyConfiguration(new StockConfiguration());
            builder.ApplyConfiguration(new ReviewConfiguration());
            builder.ApplyConfiguration(new SubCategoryConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            //builder.Entity<User>().HasData(
            //    new User
            //    {
            //        Id = 999999999,
            //        Name = "admin",
            //        Lastname = "admin",
            //        Email = "admin@mail.com",
            //        Token = "AQAAAAEAACcQAAAAEIQkMwpUcTMKwdYPY9ujciKM3zzYaDi7SAuE4niZpMamCQyZnFySZ7Dsly7s3xw93w==",
            //        Password = "AQAAAAEAACcQAAAAEPFBEHcudvFHnRPhntVlXk/nwgnxHAf+c1oVJaoJNwOt3cNdDQPKjKX4dI+aN8BNUA==",
            //        Position = admin
            //    });

        }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Breadcrumb> Breadcrumbs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ContactUs> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Chekout> Chekouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
