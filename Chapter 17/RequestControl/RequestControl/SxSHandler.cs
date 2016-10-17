using System.IO;
using System.Web;

namespace RequestControl {
    public class SxSHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {

            string reqFilePath = context.Request.FilePath;
            reqFilePath = reqFilePath.Substring(0, reqFilePath.LastIndexOf('.'));

            StringWriter htmlResponseString = new StringWriter();
            StringWriter sourceResponseString = new StringWriter();

            context.Server.Execute(reqFilePath, htmlResponseString);

            context.Server.Execute(new SourceViewHandler(), sourceResponseString, true);

            context.Items["htmlResponse"] = htmlResponseString.ToString();
            context.Items["sourceResponse"] = sourceResponseString.ToString();

            context.Server.Execute("/SxSView.aspx");
            context.ApplicationInstance.CompleteRequest();
        }

        public bool IsReusable {
            get { return false; }
        }
    }
}
