using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlState.Custom {
    public class SimpleTime : WebControl {
        private string timestamp;
        private bool stateful;

        public SimpleTime() {
            Load += (src, args) => {
                if ((timestamp = ViewState["time"] as string) != null) {
                    stateful = true;
                } else {
                    timestamp = DateTime.Now.ToLongTimeString();
                }
            };
            PreRender += (src, args) => {
                ViewState["time"] = timestamp;
            };
        }

        protected override void RenderContents(HtmlTextWriter writer) {
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            writer.Write(string.Format("Time: {0} ({1})",
                timestamp, stateful ? "State" : "New"));
            writer.RenderEndTag();
        }
    }
}