using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using PartialDemo.Models;

namespace PartialDemo.Controllers
{
    public class HomeController : Controller
    {
        

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PartialResult(int? id)
        {
            var cars = CarRepository.Instance.Cars();
            return PartialView("_Car", cars[id ?? 0]);
        }

        public ActionResult AllCars()
        {
            var cars =  CarRepository.Instance.Cars();
            return PartialView("_Cars", cars);
        }

        [ChildActionOnly] // <-- вызов только во view
        public string CurrentDate()
        {
            return DateTime.Now.ToLongDateString();
        }
    }
}