using System;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;


namespace PathsAndURLs {
    public class Global : System.Web.HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            RouteTable.Routes.EnableFriendlyUrls();
        }
    }
}
