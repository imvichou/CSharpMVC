using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Ch4_FileUpload.Controllers
{
    public class FileUploadController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(HttpPostedFileBase photo)
        //{
        //    string fileName = "";

        //    if (photo != null)
        //    {
        //        if (photo.ContentLength > 0)
        //        {
        //            fileName = Path.GetFileName(photo.FileName);

        //            var path = Path.Combine(Server.MapPath("~/Photos"), fileName);

        //            photo.SaveAs(path);
        //        }
        //    }

        //    return RedirectToAction("ShowPhotos");
        //}
        [HttpPost]
        public ActionResult Create(HttpPostedFileBase[] photos)
        {
            string fileName = "";

            for (int i = 0; i < photos.Length; i++)
            {
                HttpPostedFileBase f = (HttpPostedFileBase)photos[i];

                if (f != null)
                {
                    fileName = Path.GetFileName(f.FileName);

                    var path = Path.Combine(Server.MapPath("~/Photos"), fileName);

                    f.SaveAs(path);
                }
            }

            return RedirectToAction("ShowPhotos");
        }

        public ContentResult ShowPhotos()
        {
            string strHtml = "";

            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/Photos"));

            FileInfo[] fInfo = dir.GetFiles();

            foreach (FileInfo result in fInfo)
            {
                strHtml += $"<a href='../Photos/{result.Name}' target='_blank'>" + $"<img src='../Photos/{result.Name}' width='150' height='120' border='0'>" + $"</a>";
            }

            strHtml += "<p><a href='Create'>返回</a></p>";

            return Content(strHtml, "text/html", System.Text.Encoding.UTF8);
        }
    }
}