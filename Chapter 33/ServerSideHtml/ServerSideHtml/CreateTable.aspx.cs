using System;
using System.Collections.Generic;
using System.Web.UI.HtmlControls;

namespace ServerSideHtml {

    public partial class CreateTable : System.Web.UI.Page {
        private List<string[]> tableRows = new List<string[]> {
            new string[] {"Red", "2"},
            new string[] {"Green", "41"},
            new string[] {"Blue", "3"}
        };

        public IEnumerable<string[]> GetRows() {
            return tableRows;
        }
    }
}
