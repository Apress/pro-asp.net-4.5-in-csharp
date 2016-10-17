using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms {
    public partial class Basic : System.Web.UI.MasterPage {

        protected void Page_Load(object sender, EventArgs e) {

        }

        public string DisplayList(string[] dataItems) {
            StringBuilder sb = new StringBuilder();
            foreach (string item in dataItems) {
                sb.AppendFormat("<li>{0}</li>", item);
            }
            return sb.ToString();
        }
    }
}