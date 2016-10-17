using System;

namespace ServerSideHtml {
    public partial class Container : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            outerDiv.InnerText = "<b>This is the div element</b>";
        }
    }
}
