using System;
using System.Collections;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data.Controls {

    public class ListSelect : DataBoundControl {
        private ListItemDetails[] dataItems;
        private string selectedCategory;

        public ListSelect() {
            Load += (src, args) => {
                dataItems = ViewState["data"] as ListItemDetails[];
                if (dataItems == null) {
                    DataBind();
                }
            };
        }

        public string Value {
            get { return Context.Request.Form[GetId("listSelect")] ?? selectedCategory; }
        }

        protected override void PerformDataBinding(IEnumerable data) {
            ViewState["data"] = dataItems
                = ListItemDetails.Create(data.Cast<ListItem>().ToArray(),
                    out selectedCategory);
        }

        protected override void RenderContents(HtmlTextWriter writer) {
            writer.AddAttribute(HtmlTextWriterAttribute.Name, GetId("listSelect"));
            writer.RenderBeginTag(HtmlTextWriterTag.Select);

            foreach (ListItemDetails item in dataItems) {
                if (Value == item.Value) {
                    writer.AddAttribute(HtmlTextWriterAttribute.Selected, "selected");
                }
                writer.AddAttribute(HtmlTextWriterAttribute.Value, item.Value);
                writer.RenderBeginTag(HtmlTextWriterTag.Option);
                writer.Write(item.Text);
                writer.RenderEndTag();
            }
            writer.RenderEndTag();
        }

        protected string GetId(string name) {
            return string.Format("{0}{1}{2}", ClientID, ClientIDSeparator, name);
        }
    }

    [Serializable]
    public class ListItemDetails {
        public static ListItemDetails[] Create(ListItem[] items, out string selected) {
            ListItemDetails[] result = new ListItemDetails[items.Length];
            selected = null;
            for (int i = 0; i < items.Length; i++) {
                if (items[i].Selected) {
                    selected = items[i].Value;
                }
                result[i] = new ListItemDetails {
                    Text = items[i].Text,
                    Value = items[i].Value,
                    Selected = items[i].Selected
                };
            }
            return result;
        }
        public string Text { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }
    }
}
