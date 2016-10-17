using System.Web;
using System.Web.Routing;

namespace Routing {

    public class RedirectionRouteHandler : IRouteHandler {

        public IHttpHandler GetHttpHandler(RequestContext requestContext) {
            return new RedirectionHandler {
                TargetURL = requestContext.RouteData.DataTokens["target"].ToString()
            };
        }
    }

    public class RedirectionHandler : IHttpHandler {

        public string TargetURL { get; set; }

        public void ProcessRequest(HttpContext context) {
            context.Response.Redirect(TargetURL);
        }

        public bool IsReusable { get { return false; } }
    }
}
