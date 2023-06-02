using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _0915Filters.CustomFilters;

namespace _0915Filters.Controllers
{
    [Authorize]
    public class HomeController : Controller
    { 
        //[HandleError(View = "Error")]
        [AllowAnonymous]
        [CustomActionFilter]
        public ActionResult Index()
        {
            int[] x = new int[2];
            x[2] = 100;
            return View();
        }

        public ViewResult Welcome()
        {
            return View();
        }
    }
}