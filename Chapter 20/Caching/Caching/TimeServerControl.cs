using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching {

    [PartialCaching(60, VaryByParams = "none", Shared = true)]
    public class TimeServerControl : WebControl {

        protected override void RenderContents(HtmlTextWriter output) {
            output.WriteFullBeginTag("div");
            output.Write("The server control time is {0}",
                DateTime.Now.ToLongTimeString());
            output.WriteEndTag("div");
        }
    }
}
