using Microsoft.AspNetCore.Mvc;
using ShoppingCore.BusinessLayer.Abstract;
using ShoppingCore.EntityLayer.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCore.WebUI.Components
{
    public class CategoryComponent:ViewComponent
    {
        private readonly ICategoryServices categoryServices;

        public CategoryComponent(ICategoryServices categoryServices)
        {
            this.categoryServices = categoryServices ?? throw new ArgumentNullException(nameof(categoryServices));
        }

        public IViewComponentResult Invoke()
        {

            return View(categoryServices.GetAllProductCount());
        }
    }
}
