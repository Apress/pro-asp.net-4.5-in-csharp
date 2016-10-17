using System;

namespace Routing {
    public partial class Calc : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            int firstNumber = 0, secondNumber = 0;
            string firstString, secondString, operationString;

            if (RouteData.Values.Count > 0) {
                if (RouteData.Values.ContainsKey("numbers")) {
                    string[] elems = RouteData.Values["numbers"].ToString().Split('/');
                    firstString = elems[0];
                    secondString = elems[1];
                } else {
                    firstString = RouteData.Values["first"].ToString();
                    secondString = RouteData.Values["second"].ToString();
                }
                operationString = RouteData.Values["operation"].ToString();
            } else {
                firstString = Request["first"];
                secondString = Request["second"];
                operationString = Request["operation"];
            }

            if (firstString != null && secondString != null && operationString != null) {
                first.Value = firstString;
                second.Value = secondString;
                operation.Value = operationString;
                firstNumber = int.Parse(firstString);
                secondNumber = int.Parse(secondString);
                result.InnerText = (operationString == "plus" ?
                    firstNumber + secondNumber :
                    firstNumber - secondNumber).ToString();
                resultPh.Visible = true;
            }
        }
    }
}
