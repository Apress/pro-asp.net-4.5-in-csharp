using System;

namespace Controls {
    public partial class Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (Request.HttpMethod == "POST") {
                int firstVal = int.Parse(Request.Form["firstNumber"]);
                int secondVal = int.Parse(Request.Form["secondNumber"]);
                result.InnerText = (firstVal + secondVal).ToString();
            }
        }
    }
}
