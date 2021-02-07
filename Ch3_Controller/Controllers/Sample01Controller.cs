using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ch3_Controller.Models;

namespace Ch3_Controller.Controllers
{
    public class Sample01Controller : Controller
    {
        public ActionResult Index()
        {
            ViewData["Company"] = "大全才美食公司";
            
            List<Product> listProduct = new List<Product>();
            
            listProduct.Add(new Product { Id = "P01", Name = "香草蛋糕", Price = 300 });
            listProduct.Add(new Product { Id = "P02", Name = "碁峰可樂", Price = 100 });
            listProduct.Add(new Product { Id = "P03", Name = "龍哥豆干", Price = 200 });

            ViewBag.Products = listProduct;

            return View();
        }
    }
}