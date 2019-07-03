using Microsoft.AspNetCore.Mvc;
using ShoppingCore.BusinessLayer.Abstract;
using ShoppingCore.WebUI.Models;
using System.Linq;

namespace ShoppingCore.WebUI.Controllers.Front
{
    public class HomeController : Controller
    {

       
        private readonly IProductServices ps;
        public int PageSize = 3;

        public HomeController(IProductServices ps)
        {
            this.ps = ps;
        }
        public IActionResult Index()
        {
            // var products = ps.GetAll().Where(i=>i.IsApproved&& i.IsHome).ToList();
            var products = ps.GetAll().ToList();
            return View(products);
        }
        public IActionResult Detail(int id)
        {
            TempData["PageTitle"] = "Product";
            TempData["PageTitleSmall"] = "Detail";
            var product = ps.GetWithCategoryAndAtt(id);
            TempData["pid"] = product.Product.Id;
            return View(product);
        }
        public IActionResult List(string category,int page=1)
        {

            var products = ps.GetAll();
            if (!string.IsNullOrEmpty(category))
            {
                products = ps.GetWithCategory(category);
            }
            var count = products.Count();
            products=products.Skip((page - 1) * PageSize).Take(PageSize);
            return View(
                new ProductListModel() {
                    Products=products,
                    PagingInfo=new PagingInfo()
                    {
                        CurrentPage=page,
                        ItemPerPage=PageSize,
                        Total=count
                    }

                });
        }
    }
}