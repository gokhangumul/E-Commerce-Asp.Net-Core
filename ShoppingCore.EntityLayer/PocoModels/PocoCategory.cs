using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.EntityLayer.PocoModels
{
    public class PocoCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int ProductCount { get; set; }
    }
}
