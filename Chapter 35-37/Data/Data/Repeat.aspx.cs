using System;
using System.Collections.Generic;
using Data.Models;
using Data.Models.Repository;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data {
    public partial class Repeat : System.Web.UI.Page {

        protected void Page_Load(object src, EventArgs args) {
            rep.ItemTemplate = new RowTemplate();
        }

        public IEnumerable<Product> GetProducts() {
            return new Repository().Products;
        }

        public class RowTemplate : ITemplate {
            public void InstantiateIn(Control container) {
                Literal lit = new Literal();
                container.Controls.Add(lit);
                container.DataBinding += (src, args) => {
                    IDataItemContainer dc = ((IDataItemContainer)container);
                    Product product = (Product)dc.DataItem;
                    lit.Text =
                        string.Format("<tr {0}><td>{1}</td><td>{2}</td><td>{3}</td></tr>",
                        dc.DataItemIndex % 2 == 1 ? "class=\"alternate\"" : string.Empty,
                        product.Name, product.Category, product.Price.ToString("F2"));
                };
            }
        }
    }
}
