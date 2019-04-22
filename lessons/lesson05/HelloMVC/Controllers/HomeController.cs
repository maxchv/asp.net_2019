using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController: Controller
    {
        public ActionResult Index(int? id)
        {
            ViewBag.Title = "Title from controller";
            ViewData["message"] = "Hello friend";
            TempData["flash"] = "Flash data";
            return View(id);
        }
    }
}