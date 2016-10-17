using System.Collections;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data.Controls {
    public class DataSelect : DataBoundControl, INamingContainer {
        private object[] dataArray;

        public DataSelect() {
            Load += (src, args) => {
                dataArray = ViewState["data"] as object[];
                if (dataArray == null) {
                    DataBind();
                }
            };
        }

        public string Value {
            get { return Context.Request.Form[GetId("customSelect")]; }
        }

        [TemplateContainer(typeof(ElementItem))]
        public ITemplate ItemTemplate { get; set; }

        protected override void PerformDataBinding(IEnumerable data) {
            ViewState["data"] = dataArray = data.Cast<object>().ToArray();
        }

        protected override void RenderContents(HtmlTextWriter writer) {
            writer.AddAttribute(HtmlTextWriterAttribute.Name, GetId("customSelect"));
            writer.RenderBeginTag(HtmlTextWriterTag.Select);
            for (int i = 0; i < dataArray.Length; i++) {
                ElementItem elem = new ElementItem(i, dataArray[i]);
                elem.SelectedValue = Value;
                ItemTemplate.InstantiateIn(elem);
                elem.DataBind();
                elem.RenderControl(writer);
            }
            writer.RenderEndTag();
        }

        protected string GetId(string name) {
            return string.Format("{0}{1}{2}", ClientID, ClientIDSeparator, name);
        }
    }

    public class ElementItem : Control, IDataItemContainer {
        public ElementItem(int index, object dataItem) {
            DataItemIndex = index;
            DataItem = dataItem;
        }
        public object DataItem { get; set; }
        public int DataItemIndex { get; set; }
        public int DisplayIndex {
            get { return DataItemIndex; }
        }

        public string SelectedValue { get; set; }
        public string GenerateSelect(string category) {
            return category == SelectedValue ? "selected" : null;
        }
    }
}