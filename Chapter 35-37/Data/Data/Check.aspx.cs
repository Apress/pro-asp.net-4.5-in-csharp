using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using Data.Models.Repository;

namespace Data {
    public partial class Check : System.Web.UI.Page {

        protected void Page_Init(object src, EventArgs args) {
            cbl.SelectedIndexChanged += (s, a) => {
                List<string> selected = new List<string>();
                foreach (ListItem item in cbl.Items) {
                    if (item.Selected) {
                        selected.Add(item.Value);
                    }
                }
                selection.InnerText = String.Join(", ", selected.ToArray());
            };
        }



        public IEnumerable<string> GetProducts() {
            return new Repository().Products.Select(p => p.Name);
        }
    }
}
