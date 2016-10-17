using System;

namespace OtherControls {
    public partial class LiteralDemo : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack && colorInput.Value != string.Empty) {
                colorLiteral.Text = colorInput.Value;
            }
        }
    }
}
