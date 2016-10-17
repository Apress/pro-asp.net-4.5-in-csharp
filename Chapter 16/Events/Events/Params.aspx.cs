using System;

namespace Events {
    public partial class Params : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("Access Level:" + Request["accessLevel"]);
        }
    }
}
