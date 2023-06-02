using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0816ActionMethod.Controllers
{
    [RoutePrefix("admin")]
    public class AccountController : Controller
    {
        //// GET: Account
        //public ActionResult Index()
        //{
        //    return View();
        //}
        [Route("signin")]
        public ViewResult Login()
        {
            return View();
        }

        [Route("signup")]
        public ViewResult Register()
        {
            return View();
        }
        //[Route("display/{text:range(1,100)}")]
        [Route("display/{text:regex(\\d{3})}")]
        public ContentResult Show(int text)
        {

            return Content(text.ToString());
        }
    }
    //public class AccountController : Controller
    //{
    //    //// GET: Account
    //    //public ActionResult Index()
    //    //{
    //    //    return View();
    //    //}
    //    [Route("admin/signin")]
    //    public ViewResult Login()
    //    {
    //        return View();
    //    }

    //    [Route("admin/signup")]
    //    public ViewResult Register()
    //    {
    //        return View();
    //    }
    //}

}