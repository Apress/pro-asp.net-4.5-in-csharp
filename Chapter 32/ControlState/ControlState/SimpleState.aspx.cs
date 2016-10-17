using System;
using System.Web.UI;

namespace ControlState {
    public partial class SimpleState : System.Web.UI.Page {

        protected void Page_Init(object sender, EventArgs e) {
            RegisterRequiresControlState(this);
        }

        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) {
                ViewStateWorks = ViewState["state"] != null;
            }
            ViewState["state"] = "some state data";
        }

        protected override object SaveControlState() {
            return "some control state data";
        }

        protected override void LoadControlState(object savedState) {
            ControlStateWorks = savedState != null;
        }

        protected bool? ViewStateWorks { get; set; }
        protected bool? ControlStateWorks { get; set; }
    }
}
