using Ch5_Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch5_Razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<NightMarket> nightMarkets = new List<NightMarket>();

            nightMarkets.Add(new NightMarket { Id = "A01", Name = "逢甲夜市", Address = "407 台中市西屯區文華路" });
            nightMarkets.Add(new NightMarket { Id = "A02", Name = "一中街商圈", Address = "404 台中市北區一中街" });

            return View(nightMarkets);
        }
    }
}