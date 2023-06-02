using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _0915Filters.App_Start
{
    public class FilterConfig
    {
        public static void RegisterAllAreas(GlobalFilterCollection filters)
        {
            HandleErrorAttribute errorAttribute = new HandleErrorAttribute();
            errorAttribute.View = "Error";
            filters.Add(errorAttribute);
        }
    }
}