using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.EntityLayer.DbModels
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
