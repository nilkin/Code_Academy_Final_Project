using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>

    {
        public void Configure(EntityTypeBuilder<Testimonial> builder)
        {
            builder
     .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(m => m.Fullname)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(m => m.Info)
                .HasMaxLength(300)
                .IsRequired();
            builder
                .Property(m => m.Photo)
                .HasMaxLength(100)
                .IsRequired();
            builder
                .Property(m => m.Email)
                .HasMaxLength(50)
                .IsRequired();

            builder.ToTable("Testimonials");
        }
    }
}
