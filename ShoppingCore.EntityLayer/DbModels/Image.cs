using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCore.EntityLayer.DbModels
{
    public class Image
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
