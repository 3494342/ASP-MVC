using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0820ModelBind.Models
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        //primitive mode binding
        //[HttpPost]
        //public ContentResult Login(string username,string password)
        //{
        //    if (username == "chen" && password == "123")
        //    {
        //        return Content("Welcome chen");
        //    }
        //    else
        //    {
        //        return Content("Sorry "+ username);
        //    }
        //}

        [HttpPost]
        public ContentResult Login(User modelUser)
        {
            if (modelUser.username == "chen" && modelUser.password == "123")
            {
                return Content("Welcome chen");
            }
            else
            {
                return Content("Sorry " + modelUser.username);
            }
        }
    }
}