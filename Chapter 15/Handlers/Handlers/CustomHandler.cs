using System;
using System.Web;

namespace Handlers {
    public class CustomHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {

            string time = DateTime.Now.ToShortTimeString();

            if (context.Request.CurrentExecutionFilePathExtension == ".json") {
                context.Response.ContentType = "application/json";
                context.Response.Write(string.Format("{{\"time\": \"{0}\"}}", time));
            } else {
                context.Response.ContentType = "text/html";
                context.Response.Write(string.Format("<span>{0}</span>", time));
            }
        }

        public bool IsReusable {
            get { return false; }
        }
    }
}
