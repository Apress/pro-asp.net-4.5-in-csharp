using System;
using System.Collections.Generic;
using System.Linq;
using Data.Models.Repository;

namespace Data {
    public partial class Drop : System.Web.UI.Page {

        protected void Page_Load(object src, EventArgs args) {
            if (IsPostBack) {
                selection.InnerText = drop.SelectedValue;
            }
        }

        public IEnumerable<string> GetProducts() {
            return new Repository().Products.Select(p => p.Name);
        }
    }
}
