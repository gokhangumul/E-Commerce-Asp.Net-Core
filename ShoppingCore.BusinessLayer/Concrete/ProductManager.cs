using ShoppingCore.BusinessLayer.Abstract;
using ShoppingCore.DataAccessLayer.Abstract;
using ShoppingCore.EntityLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCore.BusinessLayer.Concrete
{
    public class ProductManager : GenericManager<Product>,IProductServices
    {
        IProductRepository rp;

        public ProductManager(IProductRepository rp) : base(rp)
        {
            this.rp=rp;
        }

        public List<Product> GetAllWithCategory()
        {
            return rp.GetAllWithCategory();
        }
    }
}
