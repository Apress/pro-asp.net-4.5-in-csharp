using System;
using System.Web;

namespace Handlers {

    public class Time : IHttpHandler, IRequiresDurationData {

        public void ProcessRequest(HttpContext context) {

            string time = DateTime.Now.ToShortTimeString();

            if (IsAjaxRequest(context.Request)) {
                context.Response.ContentType = "application/json";
                context.Response.Write(string.Format("{{\"time\": \"{0}\"}}", time));
            } else {
                context.Response.ContentType = "text/html";
                context.Response.Write(string.Format("<span>{0}</span>", time));
            }

            double? totalTime = context.Items["total_time"] as double?;
            if (totalTime != null) {
                totalTime +=
                    (DateTime.Now.Subtract(context.Timestamp).TotalMilliseconds);
                context.Items["total_time"] = totalTime;
            }
        }

        private bool IsAjaxRequest(HttpRequest request) {
            return request.Headers["X-Requested-With"] == "XMLHttpRequest"
                || request["X-Requested-With"] == "XMLHttpRequest";
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}
