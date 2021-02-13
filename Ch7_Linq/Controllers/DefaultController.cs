using Ch7_Linq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch7_Linq.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public string ShowArrayDesc()
        {
            int[] scores = new int[] { 78, 99, 20, 100, 66 };

            string show = "";

            //擴充方法
            var result = scores.OrderByDescending(m => m);

            //查詢運算式
            //var result = from m in scores orderby m descending select m;

            show = "遞減排序:";

            foreach (var m in result)
            {
                show += m + ",";
            }

            show += "<br/>";

            show += "總和:" + result.Sum();

            return show;
        }

        public string ShowArrayAsc()
        {
            int[] scores = new int[] { 78, 99, 20, 100, 66 };

            string show = "";

            //擴充方法
            var result = scores.OrderBy(m => m);

            //查詢運算式
            //var result = from m in scores orderby m ascending select m;

            show = "遞減排序:";

            foreach (var m in result)
            {
                show += m + ",";
            }

            show += "<br/>";

            show += "平均:" + result.Average();

            return show;
        }

        public string LoginMember(string uid, string pwd)
        {
            List<Member> members = new List<Member>();

            members.Add(new Member { UserId = "tom", Pwd = "123", Name = "湯姆" });
            members.Add(new Member { UserId = "jasper", Pwd = "456", Name = "賈思伯" });
            members.Add(new Member { UserId = "mary", Pwd = "789", Name = "瑪麗" });

            var result = members.Where(m => m.UserId == uid && m.Pwd == pwd).FirstOrDefault();

            string show = "";

            if (result != null)
            {
                show = result.Name + "歡迎進入系統";
            }
            else
            {
                show = "帳號密碼錯誤!";
            }

            return show;
        }
    }
}