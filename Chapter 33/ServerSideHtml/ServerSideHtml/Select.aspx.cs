using System;
using System.Diagnostics;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ServerSideHtml {
    public partial class Select : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            HtmlSelect select = new HtmlSelect { ID = "colorSelect2" };
            select.Items.Add(new ListItem { Text = "Red", Value = "red" });
            select.Items.Add(new ListItem {
                Text = "Green",
                Value = "green",
                Selected = true
            });
            select.Items.Add(new ListItem { Text = "Blue", Value = "blue" });
            container.Controls.Add(select);

            if (IsPostBack) {
                Debug.WriteLine(string.Format("colorSelect: {0}", colorSelect.Value));
                Debug.WriteLine(string.Format("colorSelect: {0}",
                    colorSelect.Items[colorSelect.SelectedIndex].Text));
                Debug.WriteLine(string.Format("colorSelect2: {0}",
                    Request.Form["colorSelect2"]));
            }

        }
    }
}
