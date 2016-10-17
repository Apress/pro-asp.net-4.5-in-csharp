using System.Web.Routing;
using System.Web.Http;
using Microsoft.AspNet.FriendlyUrls;

namespace ClientDev {
    public class RouteConfig {

        public static void RegisterRoutes(RouteCollection routes) {

            routes.MapHttpRoute(name: "WebApiRoute",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            routes.EnableFriendlyUrls();
        }
    }
}
