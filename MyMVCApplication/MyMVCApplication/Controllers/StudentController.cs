using MyMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var student = new []
            {
                new{StudentName="Scott",Age=80},
                new{StudentName="Smith",Age=25},
                new{StudentName="Vivek",Age=15},
            };
           
           ViewBag.student = student;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            // update student to the database

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            // delete student from the database whose id matches with specified id

            return RedirectToAction("Index");
        }
    }
}