using System.IO;
using System.Web;
using System.Web.UI;

namespace Handlers {
    public class SourceViewer : PageHandlerFactory {

        public override IHttpHandler GetHandler(HttpContext context, string requestType,
                string virtualPath, string path) {

            if ((context.Request.QueryString["source"] ?? "").ToLower() == "true") {
                return new SourceViewHandler();
            } else {
                return base.GetHandler(context, requestType, virtualPath, path);
            }
        }

        public override void ReleaseHandler(IHttpHandler handler) {
            if (!(handler is SourceViewer)) {
                base.ReleaseHandler(handler);
            }
        }
    }

    public class SourceViewHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            context.Response.ContentType = "text/html";
            context.Response.Write(string.Format("<h3>Contents of {0}</h3>",
                context.Request.FilePath));

            context.Response.Write("<pre>");
            StreamReader sr
                = new StreamReader(context.Request.MapPath(context.Request.FilePath));
            context.Response.Write(context.Server.HtmlEncode(sr.ReadToEnd()));
            context.Response.Write("</pre>");
        }

        public bool IsReusable {
            get { return false; }
        }
    }
}
