using ShoppingCore.EntityLayer.DbModels;
using ShoppingCore.EntityLayer.PocoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCore.DataAccessLayer.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        PocoProduct GetWithCategoryAndAtt(int id);
        IQueryable<Product> GetWithCategory(string category);
    }
}
