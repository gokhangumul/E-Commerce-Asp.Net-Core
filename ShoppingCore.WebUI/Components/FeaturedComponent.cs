using Microsoft.AspNetCore.Mvc;
using ShoppingCore.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.WebUI.Components
{
    public class FeaturedComponent:ViewComponent
    {
        private readonly IProductServices productServices;

        public FeaturedComponent(IProductServices productServices)
        {
            this.productServices = productServices ?? throw new ArgumentNullException(nameof(productServices));
        }
        public IViewComponentResult Invoke()
        {

            return View(productServices.GetAll().Where(i=>i.IsApproved&& i.IsFeatured).ToList());
        }
    }
}
