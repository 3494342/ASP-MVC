using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundle)
        {
            StyleBundle myCssBundle = new StyleBundle("~/Content/MyCss");
            myCssBundle.Include("~/Content/bootstrap.css", "~/Content/Site.css");
            //myCssBundle.Include("~/Content/*.css");//表示所有的都包含

            ScriptBundle myJsBundle = new ScriptBundle("~/scripts/MyScript");
            myJsBundle.Include("~/scripts/jquery-1.10.2.js", "~/scripts/jquery-1.10.2.min.js",
                "~/scripts/jquery.validate.unobtrusive.js", "~/scripts/jquery.validate.js");
            bundle.Add(myCssBundle);
            bundle.Add(myJsBundle);
            BundleTable.EnableOptimizations = true;//不是处于调试模式

        }
    }
}