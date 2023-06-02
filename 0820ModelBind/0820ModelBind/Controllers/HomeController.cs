using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0820ModelBind.Controllers
{
    public class HomeController : Controller
    {
        // GET: Hoem
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult VerticalForm()
        {
            return View();
        }

        public ViewResult Horizontal()
        {
            return View();

        }
    }
}