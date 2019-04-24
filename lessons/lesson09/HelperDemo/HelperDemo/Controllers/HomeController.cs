using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelperDemo.Models;

namespace HelperDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new User{Id=1, Name = "Вася", Age = 21, Gender = UserGender.Male});
        }
    }
}