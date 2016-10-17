using System.Collections;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Data.Controls {

    public class DataTable : DataBoundControl, INamingContainer {
        private object[] dataArray;

        public DataTable() {
            Load += (src, args) => {
                dataArray = ViewState["data"] as object[];
                if (dataArray == null) {
                    DataBind();
                }
            };
        }

        [TemplateContainer(typeof(TableItem))]
        public ITemplate HeaderTemplate { get; set; }

        [TemplateContainer(typeof(TableItem))]
        public ITemplate RowTemplate { get; set; }

        protected override void PerformDataBinding(IEnumerable data) {
            ViewState["data"] = dataArray = data.Cast<object>().ToArray();
        }

        protected override void RenderContents(HtmlTextWriter writer) {
            writer.RenderBeginTag(HtmlTextWriterTag.Table);

            writer.RenderBeginTag(HtmlTextWriterTag.Thead);
            TableItem item = new TableItem(-1, null);
            HeaderTemplate.InstantiateIn(item);
            item.DataBind();
            item.RenderControl(writer);
            writer.RenderEndTag();

            for (int i = 0; i < dataArray.Length; i++) {
                item = new TableItem(i, dataArray[i]);
                RowTemplate.InstantiateIn(item);
                item.DataBind();
                item.RenderControl(writer);
            }
            writer.RenderEndTag();
        }
    }

    public class TableItem : Control, IDataItemContainer {
        public TableItem(int index, object dataItem) {
            DataItem = dataItem;
            DataItemIndex = index;
        }
        public object DataItem { get; set; }
        public int DataItemIndex { get; set; }
        public int DisplayIndex { get { return DataItemIndex; } }
    }
}
