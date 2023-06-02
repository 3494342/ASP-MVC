using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace _812WebMVCPractice.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string UserName, string Password)
        {
            if (UserName == "sanshi" && Password == "pass")
            {
                FormsAuthentication.RedirectFromLoginPage("sanshi", false);
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag是一个动态对象（dynamic），可以用来存储任意参数，用来从控制器向视图传递数据。
            /*
            从控制器向视图传递数据一般有两种方法：

1.传入模型，然后在视图中通过Model对象访问，这是一种强类型的方式，也是推荐的做法。其局限性就是只能传入一个模型，如果需要传入多个模型对象，就需要自定义类来包含多个模型，另一种方法就是ViewBag。

2.ViewBag，视图包传递数据非常方便，但是在视图中可能需要进行强制类型转换。在常见的传入一个主模型和多个次模型时，可以把多次模型放到ViewBag中，从而避免自定义类的麻烦。

 

作为命名约定，这个操作方法会自动调用相应名称的视图文件About.cshtml。*/
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}