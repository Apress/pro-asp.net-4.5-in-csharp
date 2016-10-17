using System;

namespace WorkingWithForms {

    public partial class Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (Request.HttpMethod == "POST") {
                if (Request.Form["action"] == "click") {
                    result.InnerText = "The button was clicked!";
                } else {
                    result.InnerText = "The button was not clicked";
                }
            }
        }
    }
}
