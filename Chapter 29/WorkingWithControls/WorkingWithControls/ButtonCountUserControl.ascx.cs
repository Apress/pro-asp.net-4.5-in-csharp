using System;

namespace WorkingWithControls {
    public partial class ButtonCountUserControl : System.Web.UI.UserControl {

        protected void Page_Load(object sender, EventArgs e) {
            int countVal = (int)(Session["user_control_counter"] ?? 0);
            if (IsPostBack && Request.Form["button"] == "userControl") {
                Session["user_control_counter"] = ++countVal;
            }
            counter.InnerText = countVal.ToString();
        }
    }
}
