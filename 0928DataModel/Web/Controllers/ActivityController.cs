using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using ViewModels;
using Web.NewFolder1;

namespace Web.Controllers
{
    [CustomAuthentication]
    public class ActivityController : Controller
    {
        IAreaRepository repository = new AreaRepository();
        public ActionResult Index()
        {
            IEnumerable<ActivityViewModel> lstActivityViewModels = new List<ActivityViewModel>();
            return View(lstActivityViewModels);
        }
    }
}