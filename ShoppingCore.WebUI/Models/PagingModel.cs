using ShoppingCore.EntityLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.WebUI.Models
{
    public class PagingInfo
    {
        public int Total { get; set; }
        public int ItemPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages()
        {
            int tp;
            tp= (int)Math.Ceiling((decimal)Total / ItemPerPage);
            return tp;
        }

    }
    public class ProductListModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
