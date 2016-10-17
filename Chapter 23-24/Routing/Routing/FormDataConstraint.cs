using System.Web;
using System.Web.Routing;

namespace Routing {
    public class FormDataConstraint : IRouteConstraint {
        private string targetValue;

        public FormDataConstraint(string value) {
            targetValue = value;
        }

        public bool Match(HttpContextBase context,
                Route route, string parameterName,
                RouteValueDictionary values, RouteDirection direction) {

            string actualValue = context.Request.Form[parameterName];
            return actualValue != null && actualValue == targetValue;
        }
    }
}
