using System;
using System.Collections.Generic;
using System.Web.ModelBinding;
using Binding.Controls;

namespace Binding {
    public partial class Data : System.Web.UI.Page {

        public IEnumerable<string> GetData([Form] int? max, 
                [Control("opSelector", "SelectedOperator")] string operation) {
            if (operation != null) {
                for (int i = 1; i < max; i++) {
                    yield return string.Format("{0} {1} {2} = {3}",
                        max, operation == "Add" ? "+" : "-",
                        i, operation == "Add" ? (max + i) : (max - i));
                }
            }
        }
    }
}
