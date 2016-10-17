using System;
using System.IO;
using System.Web;
using System.Web.UI;

namespace RequestControl {
    public class SourceViewHandler : Page, IHttpHandler {

        public override void ProcessRequest(HttpContext context) {

            string reqFilePath = context.Request.FilePath;
            reqFilePath = reqFilePath.Substring(0, reqFilePath.LastIndexOf('.'));

            if (reqFilePath.ToLower().EndsWith(".ashx")) {
                context.Response.Redirect(reqFilePath);
            }

            StreamReader sr =
                new StreamReader(context.Request.MapPath(reqFilePath));

            context.Response.ContentType = "text/plain";
            context.Response.Write("<pre>");
            context.Response.Write(context.Server.HtmlEncode(sr.ReadToEnd()));
            context.Response.Write("</pre>");
        }

        //public bool IsReusable {
        //    get { return false; }
        //}
    }
}
