using System;
using System.Collections.Generic;

namespace WorkingWithControls {
    public partial class HtmlRepeaterButtons : System.Web.UI.Page {
        private string[] colors = { "Red", "Green", "Blue" };

        protected void Page_Load(object src, EventArgs args) {
            if (IsPostBack && Request.Form["action"] != null) {
                selectedValue.InnerText = string.Format("The {0} button was clicked",
                    Request.Form["action"]);
            }
        }

        public IEnumerable<string> GetButtonDetails() {
            return colors;
        }
    }
}
