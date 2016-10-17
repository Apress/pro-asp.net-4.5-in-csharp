using System;
using System.Diagnostics;
using System.Web.UI.HtmlControls;

namespace ServerSideHtml {
    public partial class Form5 : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            HtmlInputGenericControl rangeInput
                = new HtmlInputGenericControl("range") { ID = "userVal2" };
            rangeInput.Attributes["step"] = "5";
            rangeInput.Attributes["min"] = "50";
            rangeInput.Attributes["max"] = "100";
            inputContainer.Controls.Add(rangeInput);

            if (IsPostBack) {
                Debug.WriteLine(string.Format("Value 1: {0}", userVal.Value));
                Debug.WriteLine(string.Format("Value 2: {0}", Request["userVal2"]));
            }
        }
    }
}
