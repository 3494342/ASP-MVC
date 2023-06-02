using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using _0915Filters.Models;

namespace _0915Filters.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (FormsAuthentication.Authenticate(model.Username, model.Password))
            {
                FormsAuthentication.SetAuthCookie(model.Username,false);//不保存密码？，不产生cookies
                return RedirectToAction("Welcome", "Home");
            }
            ModelState.AddModelError("","Invalid credentials");
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}