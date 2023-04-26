using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lesson06.Models;
using lesson06.Repository;

namespace lesson06.Controllers
{
    public class HomeController : Controller
    {
        static StudentRepository studentRepository = new StudentRepository();
        
        [HttpGet]
        public ActionResult Index()
        {
            return View(studentRepository.FindAll());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Student student)
        {
            studentRepository.Save(student);
            return RedirectToAction("Index");
        }
    }
}