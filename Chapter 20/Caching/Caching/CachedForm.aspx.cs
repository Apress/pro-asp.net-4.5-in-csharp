using System;
using System.Web;

namespace Caching {
    public partial class CachedForm : System.Web.UI.Page {
        private double total = 0;

        protected void Page_Load(object src, EventArgs args) {
            if (IsPostBack) {
                total = double.Parse(quantity.Value)
                    * double.Parse(price.Value);
            }
        }

        protected string GetTotal() {
            return total == 0 ? "" : total.ToString("C");
        }

        protected string GetTimeStamp() {
            return DateTime.Now.ToLongTimeString();
        }

        protected static string GetDynamicTimeStamp(HttpContext context) {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
