using System;

namespace RequestControl {
    public partial class SxSView : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            string html = (string)Context.Items["htmlResponse"];
            string src = (string)Context.Items["sourceResponse"];

            htmlPanel.InnerHtml = html;
            srcPanel.InnerHtml = src;
        }
    }
}
