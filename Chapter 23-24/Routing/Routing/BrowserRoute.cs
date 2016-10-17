using System.Collections.Generic;
using System.Web;
using System.Web.Routing;

namespace Routing {

    public enum Browser {
        IE10, CHROME, OTHER
    }

    public class BrowserRoute : RouteBase {
        private string targetPath;
        private IDictionary<Browser, string> targetPages;

        public BrowserRoute(string path, IDictionary<Browser, string> dict) {
            targetPath = path.ToLower();
            targetPages = dict;
        }

        public override RouteData GetRouteData(HttpContextBase httpContext) {
            Browser browser;
            if (httpContext.Request.CurrentExecutionFilePath.ToLower()
                    == "/" + targetPath && targetPages.ContainsKey(browser =
                        IdentifyBrowser(httpContext.Request))) {
                return new RouteData {
                    Route = this,
                    RouteHandler = new PageRouteHandler(targetPages[browser])
                };
            } else {
                return null;
            }
        }

        private Browser IdentifyBrowser(HttpRequestBase request) {
            string uaString = request.Headers["user-agent"] ?? "";
            if (uaString.IndexOf("MSIE 10") != -1) {
                return Browser.IE10;
            } else if (uaString.IndexOf("Chrome") != -1) {
                return Browser.CHROME;
            } else {
                return Browser.OTHER;
            }
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext,
                RouteValueDictionary values) {

            return new VirtualPathData(this, targetPath);
        }
    }
}