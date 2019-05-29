using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCore.BusinessLayer;
using ShoppingCore.BusinessLayer.Abstract;
using ShoppingCore.BusinessLayer.Concrete;
using ShoppingCore.DataAccessLayer.Abstract;
using ShoppingCore.DataAccessLayer.Concrete.EfCore.Repository;
using ShoppingCore.EntityLayer.DbModels;

namespace ShoppingCore.WebUI.Controllers.Front
{
    public class HomeController : Controller
    {

        private IProductServices productServices;

        public HomeController(IProductServices productServices)
        {
            this.productServices = productServices;
        }

        public IActionResult Index()
        {
           
            return View(productServices.GetAll());
        }
    }
}