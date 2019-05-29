using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCore.DataAccessLayer.Concrete.EfCore.Context;
using ShoppingCore.EntityLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCore.DataAccessLayer.Concrete.EfCore.Repository
{
    public class Seed
    {
        public static void GetSeed(IApplicationBuilder application)
        {
            ShopContext shopContext = application.ApplicationServices.GetRequiredService<ShopContext>();
            shopContext.Database.Migrate();
            if (!shopContext.Products.Any())
            {
                var products = new[]
                {
                    new Product(){ProductName="Apple",ProductPrice=1000},
                    new Product(){ProductName="Samsung",ProductPrice=1000},
                    new Product(){ProductName="Polo", ProductPrice=2000},
                    new Product(){ProductName="Counter Strike", ProductPrice=500}
                };
                shopContext.Products.AddRange(products);
                var categories = new[]
                {
                    new Category(){CategoryName="Electronic"},
                    new Category(){CategoryName="Daily"},
                    new Category(){CategoryName="Game"}

                };
                shopContext.Categories.AddRange(categories);
                var prcategories = new[]
                {
                    new ProductCategory(){Product=products[0],Category=categories[0]},
                    new ProductCategory(){Product=products[1],Category=categories[0]},
                    new ProductCategory(){Product=products[2],Category=categories[1]},
                    new ProductCategory(){Product=products[3],Category=categories[2]},
                };
                shopContext.AddRange(prcategories);
                shopContext.SaveChanges();
            }

        }
    }
}
