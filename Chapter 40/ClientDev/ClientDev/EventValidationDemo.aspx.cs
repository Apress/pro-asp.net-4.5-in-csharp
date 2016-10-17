using System;

namespace ClientDev {
    public partial class EventValidationDemo : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            formValue.InnerText = Request.Form["nameSelect"];
        }
    }
}
