using Ch3_Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch3_Controller.Controllers
{
    public class ComplexBindController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            ViewBag.Id = product.Id;
            ViewBag.Name = product.Name;
            ViewBag.Price = product.Price;
            
            return View();
        }

    }
}