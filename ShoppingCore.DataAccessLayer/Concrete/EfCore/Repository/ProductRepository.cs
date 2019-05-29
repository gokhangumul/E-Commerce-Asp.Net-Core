using ShoppingCore.DataAccessLayer.Concrete.EfCore.Context;
using ShoppingCore.EntityLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.DataAccessLayer.Concrete.EfCore.Repository
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(ShopContext shop) : base(shop)
        {
        }
    }
}
