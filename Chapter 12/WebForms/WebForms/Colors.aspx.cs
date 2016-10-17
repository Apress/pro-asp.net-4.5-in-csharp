using System.Collections.Generic;

namespace WebForms {
    public partial class Colors : System.Web.UI.Page {

        public string[] GetColors() {
            return new string[] {"Red", "Blue", "Green", "Orange"};
        }
    }
}