using System;
using System.Web.UI;

namespace WorkingWithControls {

    public class ButtonCountResult {
        public int Index { get; set; }
        public int Count { get; set; }
    }

    public partial class TripleButtonControl : UserControl {
        protected void Page_Load(object sender, EventArgs e) {
            int index;
            if (IsPostBack && int.TryParse(Request.Form["button"], out index)) {
                GetClickCounts()[index].Count++;
            }
        }

        public ButtonCountResult[] GetClickCounts() {
            ButtonCountResult[] data;
            if ((data = (ButtonCountResult[])Session["triple_data"]) == null) {
                Session["triple_data"] = data = new ButtonCountResult[3];
                for (int i = 0; i < data.Length; i++) {
                    data[i] = new ButtonCountResult { Index = i };
                }
            }
            return data;
        }
    }
}
