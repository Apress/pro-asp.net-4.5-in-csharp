using System;
using System.Web.UI.HtmlControls;

namespace ServerSideHtml {
    public partial class SimpleTable : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) {
                IncrementCellValues(greenCell, totalCell);
            }
        }

        private void IncrementCellValues(params HtmlTableCell[] cells) {
            foreach (HtmlTableCell cell in cells) {
                cell.InnerText = (int.Parse(cell.InnerText) + 1).ToString();
            }
        }
    }
}
