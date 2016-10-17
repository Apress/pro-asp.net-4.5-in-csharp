using System.Linq;
using System.Text;
using System.Web;

namespace Caching {
    public class Global : System.Web.HttpApplication {

        public override string GetOutputCacheProviderName(HttpContext context) {
            return Request.RequestType == "POST" ?
                "AspNetInternalProvider" : "custom";
        }

        public override string GetVaryByCustomString(HttpContext context,
                string custom) {

            if (custom == "formdata") {

                var keys = context.Request.Form.AllKeys
                    .Where(k => !k.StartsWith("__"))
                    .OrderBy(k => k);

                StringBuilder sb = new StringBuilder(Request.FilePath);
                foreach (string key in keys) {
                    sb.AppendFormat("&{0}={1}", key, context.Request.Form[key]);
                }
                return sb.ToString();

            } else {
                return base.GetVaryByCustomString(context, custom);
            }
        }
    }
}
