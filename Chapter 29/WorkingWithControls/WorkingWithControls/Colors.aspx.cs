using System;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WorkingWithControls {
    public partial class Colors : System.Web.UI.Page {
        private string[] colors = { "Red", "Green", "Blue" };

        protected void Page_Load(object sender, EventArgs e) {
            HtmlGenericControl div = FindControl("buttonTarget") as HtmlGenericControl;
            foreach (string text in colors) {
                Button b = new Button();
                b.Text = text;
                b.EnableViewState = false;
                div.Controls.Add(b);
            }
            ControlUtils.AddButtonClickHandlers(this);
        }
    }
}
