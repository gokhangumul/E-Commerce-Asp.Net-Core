using ShoppingCore.EntityLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCore.DataAccessLayer.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        List<Product> GetAllWithCategory();
    }
}
