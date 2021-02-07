using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch3_Controller.Controllers
{
    public class SimpleBindController : Controller
    {
        //Get
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string Id, string Name, int Price)
        {
            ViewBag.Id = Id;
            ViewBag.Name = Name;
            ViewBag.Price = Price;

            return View();
        }
    }
}