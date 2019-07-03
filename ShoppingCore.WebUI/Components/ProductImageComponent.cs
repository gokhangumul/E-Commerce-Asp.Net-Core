using Microsoft.AspNetCore.Mvc;
using ShoppingCore.BusinessLayer.Abstract;
using ShoppingCore.EntityLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.WebUI.Components
{
    public class ProductImageComponent:ViewComponent
    {

        private readonly IServices<Image> services;

        public ProductImageComponent(IServices<Image> services)
        {
            this.services = services ?? throw new ArgumentNullException(nameof(services));
        }

        public IViewComponentResult Invoke(int id)
        {

            var list = services.GetAll(x => x.Id == id);
            return View(list);
        }
    }
}
