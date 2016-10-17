using System;
using System.Collections.Generic;

namespace Controls.Custom {

    public class Calculation {
        public BasicCalc.OperationType Operation { get; set; }
        public int Value { get; set; }
    }

    public partial class BasicCalc : System.Web.UI.UserControl {

        public enum OperationType {
            Plus,
            Minus
        }

        protected void Page_Load(object sender, EventArgs e) {
            if (Request.HttpMethod == "POST") {
                int total = int.Parse(GetFormValue("initialVal"));
                string[] numbers = GetFormValue("calcValue").Split(',');
                string[] operators = GetFormValue("calcOp").Split(',');
                for (int i = 0; i < operators.Length; i++) {
                    int val = int.Parse(numbers[i]);
                    total += operators[i] == "Plus" ? val : 0 - val;
                }
                result.InnerText = total.ToString();
            }
        }

        public List<Calculation> Calculations { get; set; }

        public List<Calculation> GetCalculations() {
            return Calculations;
        }

        public int Initial { get; set; }

        protected string GetFormValue(string name) {
            return Request.Form[GetId(name)];
        }

        protected string GetId(string name) {
            return string.Format("{0}{1}{2}", ClientID, ClientIDSeparator, name);
        }
    }
}
