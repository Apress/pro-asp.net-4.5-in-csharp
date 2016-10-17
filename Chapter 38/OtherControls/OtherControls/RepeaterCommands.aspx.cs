using System;
using System.Collections.Generic;

namespace OtherControls {
    public partial class RepeaterCommands : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            rep.ItemCommand += (src, args) => {
                if (args.CommandName == "Select") {
                    selectedValue.InnerText = args.CommandArgument.ToString();
                }
            };
        }

        public IEnumerable<string> GetData() {
            return new string[] { "Red", "Green", "Blue", "Black", "White" };
        }
    }
}
