using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace WorkingWithControls {

    public partial class RepeaterButtons : System.Web.UI.Page {
        private string[] colors = { "Red", "Green", "Blue" };

        public IEnumerable<string> GetButtonDetails() {
            return colors;
        }

        public void HandleClick(object src, RepeaterCommandEventArgs args) {
            selectedValue.InnerHtml = string.Format("The {0} button was clicked",
                ((Button)args.CommandSource).Text);
        }
    }
}
