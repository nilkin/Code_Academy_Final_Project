﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Models;

namespace ZoNaN.Data.Configuration
{
    public class ChekoutConfiguration : IEntityTypeConfiguration<Chekout>

    {
        public void Configure(EntityTypeBuilder<Chekout> builder)
        {

            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(m => m.Payment)
                .HasDefaultValue(false)
                .IsRequired();
            builder
                .Property(m => m.Shipping)
                .HasDefaultValue(false)
                .IsRequired();
            builder
                .Property(m => m.Message)
                .HasColumnType("ntext")
                .HasMaxLength(400)
                .IsRequired();
            builder
                .ToTable("Chekouts");
        }
    }
}