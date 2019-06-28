using Microsoft.EntityFrameworkCore;
using ShoppingCore.DataAccessLayer.Abstract;
using ShoppingCore.DataAccessLayer.Concrete.EfCore.Context;
using ShoppingCore.EntityLayer.DbModels;
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

        public List<Product> GetAllWithCategory()
        {
            return shopContext.Products.Include(x => x.ProductCategories).ToList();
        }
    }
}
