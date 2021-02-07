using CSharpMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpMVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            DbToDoEntities = new dbToDoEntities();
        }

        dbToDoEntities DbToDoEntities;

        public ActionResult Index()
        {
            var todos = DbToDoEntities.tToDo.OrderByDescending(x => x.fDate).ToList();

            return View(todos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string fTitle, string fLevel, DateTime fDate)
        {
            var todo = new tToDo();
            todo.fTitle = fTitle;
            todo.fLevel = fLevel;
            todo.fDate = fDate;
            DbToDoEntities.tToDo.Add(todo);
            DbToDoEntities.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var todo = DbToDoEntities.tToDo.Where(m => m.fId == id).FirstOrDefault();
            DbToDoEntities.tToDo.Remove(todo);
            DbToDoEntities.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}