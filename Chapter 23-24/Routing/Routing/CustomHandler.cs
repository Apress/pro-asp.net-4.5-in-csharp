using System.Web;

namespace Routing {

    public class CustomHandlerFactory : IHttpHandlerFactory {

        public IHttpHandler GetHandler(HttpContext context, string requestType,
                string url, string pathTranslated) {
            return new CustomHandler() { FactoryCreated = true };
        }

        public void ReleaseHandler(IHttpHandler handler) {
            // do nothing
        }
    }

    public class CustomHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            context.Response.ContentType = "text/plain";
            context.Response.Write("This is the Custom Handler");
            if (FactoryCreated) {
                context.Response.Write(" (Created via the Factory)");
            } else {
                context.Response.Write(" (Created directly)");
            }
        }

        public bool FactoryCreated { get; set; }

        public bool IsReusable {
            get { return false; }
        }
    }
}
