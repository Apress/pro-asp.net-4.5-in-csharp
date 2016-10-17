using System.Web;

namespace Routing {
    public class GenHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            context.Response.ContentType = "text/plain";
            context.Response.Write("This is the Generic Handler");
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}
