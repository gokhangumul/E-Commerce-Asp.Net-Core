using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.EntityLayer.DbModels
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
