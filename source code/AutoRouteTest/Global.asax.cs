using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace AutoRouteTest
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // route all aspx pages in the project
            // scan through all folders (including folders of javascript, images, css)
            AutoRoute.RouteAllPages();

            // route all aspx pages in specific folder, including sub-folders
            //AutoRoute.Route("~/pages", true);

            // route all aspx pages in specific folder, do not include pages in sub-folders
            //AutoRoute.Route("~/pages", false);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}