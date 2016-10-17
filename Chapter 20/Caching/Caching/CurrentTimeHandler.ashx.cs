using System;
using System.Web;

namespace Caching {

    public class CurrentTimeHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            context.Response.ContentType = "text/plain";
            context.Response.Write(string.Format("Response generated at: {0}",
                DateTime.Now.ToLongTimeString()));
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}
