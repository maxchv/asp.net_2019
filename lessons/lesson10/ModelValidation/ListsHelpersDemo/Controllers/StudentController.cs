using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListsHelpersDemo.Models;
using ListsHelpersDemo.ViewModel;

namespace ListsHelpersDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View(Academy.Instance.Students);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            var groups = new SelectList(Academy.Instance.Groups,"Id", "Name", 2);
            ViewBag.Groups = groups;
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(StudentViewModel viewModel)
        {
            try
            {
                Academy.Instance.Save(viewModel.Student);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            var student = Academy.Instance.Students.Find(s => s.Id == id);
            Academy.Instance.Students.Remove(student);
            return RedirectToAction("Index");
        }
    }
}
