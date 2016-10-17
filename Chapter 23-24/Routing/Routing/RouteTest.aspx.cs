using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Routing;

namespace Routing {

    public class RouteMatchInfo {
        public bool matches { get; set; }
        public string path { get; set; }
        public string values { get; set; }
    }

    public partial class RouteTest : System.Web.UI.Page {

        public IEnumerable<RouteMatchInfo> GetRouteMatches() {

            HttpContextBase contextBase
                = new ContextMapper((string)Context.Items["routePath"]);

            foreach (RouteBase rbase in RouteTable.Routes) {
                Route route = rbase as Route;
                RouteData rData = route.GetRouteData(contextBase);
                if (rData != null) {
                    StringBuilder sb = new StringBuilder();
                    foreach (string key in rData.Values.Keys) {
                        sb.AppendFormat("{0} = {1},", key, rData.Values[key]);
                    }
                    yield return new RouteMatchInfo {
                        matches = true,
                        path = route.Url,
                        values = sb.ToString()
                    };
                } else {
                    yield return new RouteMatchInfo {
                        matches = false,
                        path = route.Url,
                        values = "-"
                    };
                }
            }
        }
    }
}
