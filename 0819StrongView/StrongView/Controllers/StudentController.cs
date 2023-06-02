using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StrongView.Models;

namespace StrongView.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ViewResult Index()
        {
            Student st = new Student() {Rollno = 1,Name="Chen",Number = "80029574"};
            return View(st);
        }

        public ViewResult List()
        {
            List<Student> lsList = new List<Student>()
            {
                new Student() {Rollno = 1,Name = "Chen",Number = "8001"},
                new Student() {Rollno = 2,Name = "hen",Number = "8002"}
            };
            return View(lsList);
        }
    }
}