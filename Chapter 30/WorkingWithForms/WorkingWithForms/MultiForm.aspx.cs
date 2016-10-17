using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace WorkingWithForms {
    public partial class MultiForm : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (Request.HttpMethod == "POST") {
                string name = Request.Form["button"];
                result.InnerText = string.Format("The {0} is {1}", name, GetValue(name));
            }
        }

        private string GetValue(string name) {
            string formValue = Request.Form[name];
            if (formValue != null) {
                Control c = FindControl(name);
                if (c is HtmlInputText) {
                    ((HtmlInputText)c).Value = formValue;
                }
            }
            return formValue;
        }
    }
}
