using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StrongView.Controllers
{
    public class CourseDetailsController : Controller
    {
        // GET: CourseDetails
        public ViewResult DoNot()
        {
            return View();
        }
        public ViewResult PHP()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult Sidebar()
        {
            string[] course = {"PHP", "Dot Net", "Java"};
            return PartialView("_Sidebar",course);
        }
    }
}