using Microsoft.EntityFrameworkCore;
using ShoppingCore.DataAccessLayer.Abstract;
using ShoppingCore.DataAccessLayer.Concrete.EfCore.Context;
using ShoppingCore.EntityLayer.DbModels;
using ShoppingCore.EntityLayer.PocoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCore.DataAccessLayer.Concrete.EfCore.Repository
{
    public class ProductRepository : GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(ShopContext shop) : base(shop)
        {

        }

        public IQueryable<Product> GetWithCategory(string category)
        {
            var product = shopContext.Products
                .Include(x => x.ProductCategories)
                .ThenInclude(x => x.Category)
                .Where(x => x.ProductCategories.Any(a => a.Category.CategoryName == category));
            return product;    
              
        }

        public PocoProduct GetWithCategoryAndAtt(int id)
        {
            var pocoproduct = shopContext.Products.Where(x => x.Id == id)
                .Include(x => x.ProductAttributes)
                .Include(x => x.ProductCategories)
                .ThenInclude(x => x.Category)
                .Select(x => new PocoProduct()
                {
                    Product = x,
                    ProductAttributes = x.ProductAttributes,
                    Categories = x.ProductCategories.Select(i => i.Category).ToList()
                }).FirstOrDefault();
            return pocoproduct;
        }
    }
}
