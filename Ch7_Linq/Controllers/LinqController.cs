using Ch7_Linq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch7_Linq.Controllers
{
    public class LinqController : Controller
    {
        // GET: Linq
        public string ShowEmployee()
        {
            NorthwindEntities db = new NorthwindEntities();

            var result = db.員工;

            //var result = from m in db.員工 select m;

            string show = "";
            foreach (var m in result)
            {
                show += $"編號:{m.員工編號}<br/>";
                show += $"姓名:{m.姓名+ m.稱呼}<br/>";
                show += $"職稱:{m.職稱}<hr/>";
            }

            return show;
        }

        public string ShowCustomerByAddress(string keyword)
        {
            NorthwindEntities db = new NorthwindEntities();

            var result = db.客戶.Where(m => m.地址.Contains(keyword));

            //var result = from m in db.客戶 where m.地址.Contains(keyword) select m;

            string show = "";
            foreach (var m in result)
            {
                show += $"公司:{m.公司名稱}<br/>";
                show += $"姓名:{m.連絡人}{ m.連絡人職稱}<br/>";
                show += $"地址:{m.地址}<hr/>";
            }

            return show;
        }
    }
}