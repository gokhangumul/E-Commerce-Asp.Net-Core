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

       
        private readonly IProductServices ps;

        public HomeController(IProductServices ps)
        {
            this.ps = ps;
        }
        public IActionResult Index()
        {
            // var products = ps.GetAll().Where(i=>i.IsApproved&& i.IsHome).ToList();
            var products = ps.GetAll();
            return View(products);
        }
    }
}