﻿using Ch6_HtmlHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch6_HtmlHelper.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialView
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = "AEL019800", Name = "跟著實務學習 ASP.NET MVC 5", Price = 540 });
            products.Add(new Product { Id = "AEL021400", Name = "跟著實務學習網頁設計", Price = 500 });
            products.Add(new Product { Id = "AEL022231", Name = "跟著實務學習 Bootstrap與JS", Price = 540 });
            products.Add(new Product { Id = "AEL022131", Name = "Python 基礎必修課-第二版", Price = 450 });
            products.Add(new Product { Id = "AEL022500", Name = "JAVA SE 12基礎必修課", Price = 540 });
            products.Add(new Product { Id = "AEL022600", Name = "Visual C# 2019 基礎必修課", Price = 530 });

            return View(products);
        }
    }
}