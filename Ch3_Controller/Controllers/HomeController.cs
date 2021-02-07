using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch3_Controller.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Company"] = "大全才資訊";
            ViewBag.Company = "大全才資訊";
            TempData["Company"] = "大全才資訊";
            return View();
        }

        public string ShowArray()
        {
            int[] scores = new int[] { 78, 89, 30, 100, 66 };
            string show = "";
            int sum = 0;

            foreach (var score in scores)
            {
                show += score + ",";
                sum += score;
            }

            show = show.Substring(0, show.Length - 1);
            show += "<br />";
            show += "總合:" + sum;

            return show;
        }

        string[] name = new string[] {"Stitch","Winnie Pooh" };
        
        //傳回顯示name字串陣列的html字串
        public string ShowImages()
        {
            string show = "<h2>卡通人物</h2>";

            for (int i = 0; i < name.Length; i++)
            {
                show += $"<img src='../Images/{name[i]}.png' width='150'>";
            }

            return show;
        }

        //依index參數取得對應圖片
        public string ShowImageByIndex(int index)
        {
            string show = $"<h3>index參數必須介於0~{name.GetUpperBound(0)}</h3>";

            if (index >= 0 && index <= name.GetUpperBound(0))
            {
                show = $"<p align='center'>"+ $"<img src='../Images/{name[index]}.png' width='350'>" + $"<br>{name[index]}</p>";
            }

            return show;
        }
    }
}