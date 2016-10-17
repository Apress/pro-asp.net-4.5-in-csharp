using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Binding.Controls {
    public class FieldValidator : WebControl {

        public string PropertyName { get; set; }

        protected override void RenderContents(HtmlTextWriter writer) {
            ModelState mState;
            if (PropertyName != null && !Page.ModelState.IsValid
                && (mState = Page.ModelState[PropertyName]) != null
                && mState.Errors != null && mState.Errors.Count > 0) {
                if (CssClass != null) {
                    writer.AddAttribute("class", CssClass);
                }
                writer.RenderBeginTag(HtmlTextWriterTag.Span);
                writer.Write("*");
                writer.RenderEndTag();
            }
        }
    }
}