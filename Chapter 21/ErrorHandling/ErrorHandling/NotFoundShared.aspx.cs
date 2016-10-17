using System;

namespace ErrorHandling {
    public partial class NotFoundShared : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            requestedURL.InnerText = Request["aspxerrorpath"] ?? Request.RawUrl;
            errorSrc.InnerText = Request["aspxerrorpath"] == null ? "IIS" : "ASP.NET";

        }
    }
}
