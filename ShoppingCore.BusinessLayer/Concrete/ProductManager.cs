using ShoppingCore.DataAccessLayer.Abstract;
using ShoppingCore.EntityLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.BusinessLayer.Concrete
{
    public class ProductManager : GenericManager<Product>
    {
        public ProductManager(IGenericRepository<Product> genericRepository) : base(genericRepository)
        {
        }
    }
}
