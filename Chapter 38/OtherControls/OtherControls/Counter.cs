using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtherControls {

    public class Counter : CompositeControl {
        private int counterValue;

        public Counter() {
            Init += (src, args) => {
                Page.RegisterRequiresControlState(this);
            };
        }

        protected override bool OnBubbleEvent(object source, EventArgs args) {
            CommandEventArgs commandArgs = args as CommandEventArgs;
            string action = commandArgs == null ? string.Empty : commandArgs.CommandName;
            if (action == "Up") {
                counterValue++;
                return true;
            } else if (action == "Down") {
                counterValue--;
                return true;
            } else {
                return false;
            }
        }

        protected override object SaveControlState() {
            return counterValue;
        }

        protected override void LoadControlState(object savedState) {
            counterValue = (int)(savedState ?? 0);
        }

        protected override void CreateChildControls() {
            TemplateItem tItem = new TemplateItem();
            UITemplate.InstantiateIn(tItem);
            tItem.DataBind();
            Controls.Add(tItem);
        }

        [TemplateContainer(typeof(TemplateItem))]
        public ITemplate UITemplate { get; set; }

        protected override void RenderContents(HtmlTextWriter writer) {
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            writer.Write("Counter value: {0}", counterValue);
            writer.RenderEndTag();
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            RenderChildren(writer);
            writer.RenderEndTag();
        }
    }

    public class TemplateItem : Control, IDataItemContainer {
        public object DataItem { get; set; }
        public int DataItemIndex { get; set; }
        public int DisplayIndex {
            get { return DataItemIndex; }
        }
    }
}
