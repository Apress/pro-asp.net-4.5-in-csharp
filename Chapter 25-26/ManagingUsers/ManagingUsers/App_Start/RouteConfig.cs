using System.Web.Routing;

namespace ManagingUsers {

    public class RouteConfig {

        public static void RegisterRoutes(RouteCollection routes) {
            routes.MapPageRoute(null, "", "~/Default.aspx", true);
            routes.MapPageRoute(null, "restricted", "~/Admin/Restricted.aspx", true);
        }
    }
}
