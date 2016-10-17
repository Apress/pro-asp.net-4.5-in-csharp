using System;
using System.Web;

namespace WorkingWithForms {
    public partial class Valid : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (Request.HttpMethod == "POST") {
                try {
                    nameResult.InnerText = Request.Form["name"];
                } catch (HttpRequestValidationException) {
                    nameResult.InnerText = "Dangerous data!";
                }
                htmlResult.InnerText = Request.Unvalidated.Form["html"];
            }
        }
    }
}
