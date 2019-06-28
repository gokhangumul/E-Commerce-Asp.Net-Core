using ShoppingCore.EntityLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCore.BusinessLayer.Abstract
{
    public interface IProductServices:IServices<Product>
    {
        List<Product> GetAllWithCategory();
    }
}
