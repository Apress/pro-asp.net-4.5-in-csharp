using System;
using System.Web;

namespace RequestControl {

    public class CurrentTimeHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            context.Response.ContentType = "text/plain";
            context.Response.Write(string.Format("The time is: {0}",
                DateTime.Now.ToShortTimeString()));
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}
