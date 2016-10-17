using System.Web;
using System.Web.Routing;

namespace Routing {
    public class StopASPXRouteHandler : IRouteHandler, IHttpHandler {

        public IHttpHandler GetHttpHandler(RequestContext requestContext) {
            return this;
        }

        public void ProcessRequest(HttpContext context) {
            context.Response.StatusCode = 404;
            context.ApplicationInstance.CompleteRequest();
        }

        public bool IsReusable {
            get { return false; }
        }
    }

    public static class StopASPXRoutingHelper {

        public static void StopASPXRequests(this RouteCollection routes) {
            routes.RouteExistingFiles = true;
            routes.Add("noaspx", new Route("{*path}", null,
                new RouteValueDictionary { { "path", @"?i:^.*\.aspx.*$" } },
                new StopASPXRouteHandler()));
        }
    }
}
