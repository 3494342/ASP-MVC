using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0915Filters.CustomFilters
{
    public class CustomActionFilterAttribute:FilterAttribute,IActionFilter
    {
        Stopwatch watch;

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            watch.Stop();
            filterContext.HttpContext.Response.Write("Action Execution Time is " + watch.ElapsedTicks.ToString());

        }
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            watch = Stopwatch.StartNew();
        }
    }
}