using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _0907Ajax.Models;

namespace _0907Ajax.Controllers
{
    public class AJaxlinkController : Controller
    {
        private IEnumerable<Course> lstCourses = Course.GetCourses();
        private IEnumerable<Subject> lstsubjects = Subject.GetSubjects();
        // GET: AJaxlink
        public ActionResult Index()
        {
            ViewBag.Courses = lstCourses;
            return View();
        }

        public JsonResult DisplaySub(int cid)
        {
            IEnumerable<Subject> subjects = lstsubjects.Where(s => s.CourseId == cid);
            return Json(subjects,JsonRequestBehavior.AllowGet);
        }
    }
}