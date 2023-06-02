using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace _0816ActionMethod.Controllers
{
    public class MethodController : Controller
    {
        // GET: Method
        public ActionResult Index()
        {
            ViewBag.colors = new string[] {"red", "green", "blue"};
            TempData["name"] = "chen";
            TempData["number"] = "80029574";

            Session["user"] = "name";
            //添加cookie
            HttpCookie myCookie = new HttpCookie("role");
            myCookie.Value = "Prime User";
            myCookie.Expires = System.DateTime.Now.AddMinutes(10);
            Response.Cookies.Add(myCookie);
            return View("Index");
        }
        public string greet()
        {
            return "hello!";
        }
        //默认是HttpGet
        //[HttpPost]
        public ViewResult Contact()
        {
            return View("Contact");
        }
        public ContentResult Courses(string title)
        {
            return Content(title);
        }
        public ContentResult Display(int cid)
        {
            return Content(cid.ToString());
        }

        public ActionResult About()
        {
            if (Request.Cookies["role"] != null)
            {
                ViewBag.msg = Request.Cookies["role"].Value;
            }
            else
            {
                ViewBag.msg = "cookies expired";
            }
            
            return View();
        }
        //public FileResult Show()
        //{
        //    return File(Server.MapPath("~/Content/Site.css"),"text/plain");
        //}

        //public FileResult Download()
        //{
        //    return File(Server.MapPath("~/Content/Site.css"), "text/plain","MVC5.TXT");
        //}
        //public RedirectResult ShowExternal()
        //{
        //    return new RedirectResult("http://www.asp.net");
        //}

        //public RedirectResult ShowInternal()
        //{
        //    return new RedirectResult("~/Views/Method/Index.cshtml");
        //}

        //public RedirectToRouteResult showRoute()
        //{
        //    return RedirectToRoute(new {Controller = "Method",Action= "ShowExternal" });
        //}

        //public RedirectToRouteResult ShowResult()
        //{
        //    return RedirectToAction("ShowExternal");
        //}
    }
}