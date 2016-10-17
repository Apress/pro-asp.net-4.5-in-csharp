using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Binding.Controls {
    public class OperationSelector : WebControl {
        private string[] operators = { "Add", "Substract" };
        private string selectedOperator;

        public string SelectedOperator {
            get {
                return selectedOperator ?? operators[0];
            }
        }

        public OperationSelector() {
            Load += (src, args) => {
                if (Page.IsPostBack) {
                    selectedOperator = Context.Request[GetFormId("op")];
                }
            };
        }

        protected override void RenderContents(HtmlTextWriter writer) {
            writer.AddAttribute(HtmlTextWriterAttribute.Name, GetFormId("op"));
            writer.RenderBeginTag(HtmlTextWriterTag.Select);

            foreach (string op in operators) {
                writer.AddAttribute(HtmlTextWriterAttribute.Value, op);
                if (op == SelectedOperator) {
                    writer.AddAttribute(HtmlTextWriterAttribute.Selected, "selected");
                }
                writer.RenderBeginTag(HtmlTextWriterTag.Option);
                writer.Write(op);
                writer.RenderEndTag();
            }
            writer.RenderEndTag();
        }

        private string GetFormId(string name) {
            return string.Format("{0}{1}{2}", ClientID, ClientIDSeparator, name);
        }
    }
}