using ShoppingCore.EntityLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.EntityLayer.PocoModels
{
    public class PocoProduct
    {
        public Product Product { get; set; }
        public List<ProductAttribute> ProductAttributes { get; set; }
        public List<Category> Categories { get; set; }
    }
}
