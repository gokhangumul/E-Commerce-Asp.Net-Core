using ShoppingCore.EntityLayer.DbModels;
using ShoppingCore.EntityLayer.PocoModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.BusinessLayer.Abstract
{
    public interface ICategoryServices:IServices<Category>
    {
       IEnumerable<PocoCategory> GetAllProductCount();
    }
}
