using System;

namespace ServerSideHtml {
    public partial class Structure : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            Header.Description = "A simple example";
            Header.Title = "Structure Elements";
            Header.Keywords = "ASP.NET, HTML, example, Apress";
        }
    }
}
