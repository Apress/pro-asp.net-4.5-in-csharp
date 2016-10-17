using System.Web;
using System.Web.Compilation;
using System.Web.UI;

namespace Events {

    public class WebFormHandlerFactory : IHttpHandlerFactory {

        public IHttpHandler GetHandler(HttpContext context, string requestType,
                string url, string pathTranslated) {

            Page page = BuildManager.CreateInstanceFromVirtualPath(
                context.Request.Path, typeof(Page)) as Page;

            context.Response.Write(
                string.Format("<div style=\"padding=10px;background-color="
                + "lightgrey;border=thin solid black\">Content from {0}</div>",
                context.Request.Path));

            return page;
        }

        public void ReleaseHandler(IHttpHandler handler) {
            // do nothing - handlers are not recycled
        }
    }
}