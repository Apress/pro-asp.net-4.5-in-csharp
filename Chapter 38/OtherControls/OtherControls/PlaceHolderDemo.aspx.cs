using System;

namespace OtherControls {
    public partial class PlaceHolderDemo : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            ph.Visible = show.Checked;
        }
    }
}
