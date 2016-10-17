using System;
using System.Web.UI;

namespace OtherControls {
    public partial class Default : System.Web.UI.Page {

        protected void HandleClick(object src, EventArgs args) {
            string controlID = (string)Session["myControl"];
            if (controlID != null && ((Control)src).ID == controlID) {
                result.InnerText = (int.Parse(result.InnerText) + 1).ToString();
            }
            Session["myControl"] = ((Control)src).ID;
        }
    }
}
