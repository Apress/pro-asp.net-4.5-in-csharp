using System;

namespace ControlState.Custom {

    [Serializable]
    public class CounterControlState {
        public int LeftValue { get; set; }
        public int RightValue { get; set; }
    }

    public partial class Counter : System.Web.UI.UserControl {

        public int LeftValue { get; set; }
        public int RightValue { get; set; }

        protected void Page_Init(object sender, EventArgs e) {
            Page.RegisterRequiresControlState(this);
        }

        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) {
                string button = GetValue("button");
                if (button == GetId("left")) {
                    LeftValue++;
                } else if (button == GetId("right")) {
                    RightValue++;
                }
            }
        }

        protected override object SaveControlState() {
            return new CounterControlState {
                LeftValue = this.LeftValue,
                RightValue = this.RightValue
            };
        }

        protected override void LoadControlState(object savedState) {
            CounterControlState state = savedState as CounterControlState;
            if (state != null) {
                LeftValue = state.LeftValue;
                RightValue = state.RightValue;
            }
        }

        protected string GetValue(string name) {
            string id = GetId(name);
            return Request.Form[id] ?? Request[id];
        }

        protected string GetId(string name) {
            return string.Format("{0}{1}{2}", ClientID, ClientIDSeparator, name);
        }
    }
}
