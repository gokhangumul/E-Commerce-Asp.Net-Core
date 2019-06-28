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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ShopContext shop) : base(shop)
        {
        }

        public IEnumerable<PocoCategory> GetAllProductCount()
        {
           
            return shopContext.Categories.Select(i => new PocoCategory()
            {
                CategoryName=i.CategoryName,
                Id=i.Id,
                ProductCount=i.ProductCategories.Count()
            });
        }
    }
}
