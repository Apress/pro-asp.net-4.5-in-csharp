using System.Web.Routing;

namespace Routing.Store {
    public partial class Cart : System.Web.UI.Page {

        protected string GetURLFromRoute() {
            Route myRoute = RouteData.Route as Route;
            if (myRoute != null) {
                return myRoute.Url;
            } else {
                return "Unknown RouteBase";
            }
        }
    }
}
