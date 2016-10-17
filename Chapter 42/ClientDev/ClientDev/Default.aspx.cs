using System;

namespace ClientDev {
    public partial class Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            string selectedColor;
            if (IsPostBack && (selectedColor = Request.Form["color"]) != null) {
                selectedValue.InnerText = selectedColor;
            }
        }
    }
}
