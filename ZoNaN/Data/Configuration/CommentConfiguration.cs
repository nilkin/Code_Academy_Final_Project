using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using ZoNaN.Data.Models;

namespace ZoNaN.Data.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
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
                .Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(m => m.Subject)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(m => m.Message)
                .HasMaxLength(500)
                .HasColumnType("ntext");
            builder
                .Property(m => m.Photo)
                .HasDefaultValue("avatar.jpg")
                .HasMaxLength(100);
            builder
                .Property(m => m.Website)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(m => m.AddedDate)
                .HasDefaultValue(DateTime.Now);
            builder
                .HasOne(m => m.Blog)
                .WithMany(m => m.Comments)
                .HasForeignKey(m => m.BlogId);
            builder.ToTable("Comments");
        }
    }
}
