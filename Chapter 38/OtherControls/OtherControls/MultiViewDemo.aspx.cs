using System;

namespace OtherControls {
    public partial class MultiViewDemo : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            mView.ActiveViewIndex = nameSelect.SelectedIndex;
        }
    }
}
