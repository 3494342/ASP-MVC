﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_PostAuthenticateRequest(object sender, EventArgs e)
        {
            HttpCookie auCookie = Request.Cookies.Get(FormsAuthentication.FormsCookieName);
            if (auCookie!=null)
            {
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(auCookie.Value);
                string udata = ticket.UserData;

                string[] userdata = udata.Split('|');
                

            }
        }
    }
}
