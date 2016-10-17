using System.IO;
using System.Web;

namespace PathsAndURLs {
    public class ExtensionlessHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {

            context.Response.Write("<p>Expressionless Handler</p>");
            string vpath = context.Request.Path;
            if (vpath == "/") {
                context.Server.Transfer("/Default.aspx");
            } else if (File.Exists(context.Request.MapPath(vpath + ".aspx"))) {
                context.Server.Transfer(vpath + ".aspx");
            } else {
                context.Response.StatusCode = 404;
                context.ApplicationInstance.CompleteRequest();
            }
        }

        public bool IsReusable {
            get { return false; }
        }
    }
}
