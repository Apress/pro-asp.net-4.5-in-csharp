using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using Data.Models.Repository;

namespace Data {
    public partial class List : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) {
                List<string> selected = new List<string>();
                foreach (ListItem item in list.Items) {
                    if (item.Selected) {
                        selected.Add(item.Value);
                    }
                }
                selection.InnerText = String.Join(", ", selected.ToArray());
            }
        }

        public IEnumerable<string> GetProducts() {
            return new Repository().Products.Select(p => p.Name);
        }
    }
}
