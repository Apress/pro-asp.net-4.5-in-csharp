using System;

namespace ClientDev {
    public partial class Simple : System.Web.UI.Page {

        protected void Page_PreInit(object sender, EventArgs e) {
            MasterPageFile = Request.Browser.IsMobileDevice ?
                "Site.Mobile.Master" : "Site.Master";
        }
    }
}
