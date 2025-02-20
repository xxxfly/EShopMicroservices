﻿using Discount.Grpc.Models;
using Microsoft.EntityFrameworkCore;

namespace Discount.Grpc.Data;
public class DiscountContext : DbContext
{
    public DbSet<Coupon> Coupons { get; set; } = default!;

    public DiscountContext(DbContextOptions<DiscountContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coupon>().HasData(
            new Coupon { Id = 1, ProductName = "IPhone 16", Description = "IPhone Discount", Amount = 150 },
            new Coupon { Id = 2, ProductName = "Xiaomi Mi 14", Description = "Xiaomi Discount", Amount = 100 }
            );
    }
}


