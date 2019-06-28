using ShoppingCore.EntityLayer.DbModels;
using ShoppingCore.EntityLayer.PocoModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.DataAccessLayer.Abstract
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
       IEnumerable<PocoCategory> GetAllProductCount();
    }
}
