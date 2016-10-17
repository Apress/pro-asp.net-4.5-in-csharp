using System;
using System.Collections.Generic;

namespace ControlState.Custom {

    public partial class Calc : System.Web.UI.UserControl {
        private List<string> history = new List<string>();

        protected void Page_Init(object sender, EventArgs args) {
            Page.RegisterRequiresControlState(this);
        }

        protected override void LoadControlState(object savedState) {
            history = savedState as List<string> ?? new List<string>();
        }

        protected override object SaveControlState() {
            return history.Count > 3 ? history.GetRange(0, 3) : history;
        }

        protected void Page_Load(object sender, EventArgs args) {
            if (IsPostBack) {
                int result = int.Parse(firstValue.Value) + int.Parse(secondValue.Value);
                resultValue.InnerText = result.ToString();
                history.Insert(0, string.Format("{0} + {1} = {2}", firstValue.Value,
                    secondValue.Value, result));
            }
        }

        public IEnumerable<string> GetHistory() {
            return history;
        }
    }
}
