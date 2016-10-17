using System.Web.Routing;

namespace Routing {
    public partial class Out : System.Web.UI.Page {

        protected string GenerateURL() {
            return GetRouteUrl(new RouteValueDictionary {
                    {"first", "10"}, {"operation", "plus"},{"second", "20"}});
        }
    }
}
