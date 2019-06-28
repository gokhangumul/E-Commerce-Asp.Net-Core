using Microsoft.EntityFrameworkCore;
using ShoppingCore.EntityLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.DataAccessLayer.Concrete.EfCore.Context
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions <ShopContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet <ProductAttribute> ProductAttributes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)//Many to Many
        {
            modelBuilder.Entity<ProductCategory>().HasKey(pk => new
            {
                pk.ProductId,
                pk.CategoryId
            });
        }
    }
}
