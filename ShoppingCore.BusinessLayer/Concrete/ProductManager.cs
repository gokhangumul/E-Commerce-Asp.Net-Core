using ShoppingCore.BusinessLayer.Abstract;
using ShoppingCore.DataAccessLayer.Abstract;
using ShoppingCore.EntityLayer.DbModels;
using ShoppingCore.EntityLayer.PocoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCore.BusinessLayer.Concrete
{
    public class ProductManager : GenericManager<Product>,IProductServices
    {
        private readonly IProductRepository rp;

        public ProductManager(IProductRepository rp) : base(rp)
        {
            this.rp=rp;
        }

        public IQueryable<Product> GetWithCategory(string category)
        {
            return rp.GetWithCategory(category);
        }

        public PocoProduct GetWithCategoryAndAtt(int id)
        {
            return rp.GetWithCategoryAndAtt(id);
        }
    }
}
