using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lesson11.Filters;

namespace lesson11.Controllers
{
    //[MyActionFilter]
    public class HomeController : Controller
    {
        //[MyActionFilter]
        //[Authorize]
        public ActionResult Index()
        {
            Debug.WriteLine("Start action");
            return View();
        }

        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "MathError")]
        public string Math(int div = 2)
        {
            int a = 1 / div;
            Response.ContentType = "text/plain";
            Response.StatusCode = 500;
            return $"a = ${a}";
        }

        public string HelloWorld()
        {
            Response.ContentType = "text/plain";
            return "Hello World";
        }
    }
}