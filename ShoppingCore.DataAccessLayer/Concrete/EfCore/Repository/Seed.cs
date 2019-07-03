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
                    new Product(){
                        ProductName ="Apple",
                        ProductPrice =1000,
                        ImagePath ="product1.jpg",
                        ProductDescription ="Description1",
                        HtmlContent ="<b>Html Content1 </b>",
                        CreatedTime=DateTime.Now.AddDays(-10)
                    },
                    new Product(){
                        ProductName ="Samsung",
                        ProductPrice =1000,
                        ImagePath ="product2.jpg",
                        ProductDescription ="Description2",
                        HtmlContent ="<b>Html Content2</b>",
                        CreatedTime=DateTime.Now.AddDays(-9)
                    },
                    new Product(){
                        ProductName ="Polo",
                        ProductPrice =1000,
                        ImagePath ="product3.jpg",
                        ProductDescription ="Description3",
                        HtmlContent ="<b>Html Content3 </b>",
                        CreatedTime=DateTime.Now.AddDays(-5)
                    },
                    new Product(){
                        ProductName ="Counter Strike",
                        ProductPrice =1000,
                        ImagePath ="product4.jpg",
                        ProductDescription ="Description4",
                        HtmlContent ="<b>Html Content4 </b>",
                        CreatedTime=DateTime.Now.AddDays(-3)
                    }
                  
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

                var pattribute = new[]
                {
                    new ProductAttribute(){Attribute="Display", Value="15.6",Product=products[0]},
                     new ProductAttribute(){Attribute="Display", Value="15.6",Product=products[0]},
                      new ProductAttribute(){Attribute="Display", Value="15.6",Product=products[0]},
                       new ProductAttribute(){Attribute="Display", Value="15.6",Product=products[0]}

                };
                shopContext.ProductAttributes.AddRange(pattribute);
                shopContext.SaveChanges();
            }

        }
    }
}
