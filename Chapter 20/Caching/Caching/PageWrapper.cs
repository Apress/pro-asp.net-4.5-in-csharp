using System.Web;
using System.Web.UI;

namespace Caching {

    class PageWrapper : Page {
        private IHttpHandler wrappedHandler;

        public PageWrapper(IHttpHandler handler) {
            wrappedHandler = handler;
        }

        public override void ProcessRequest(HttpContext context) {
            wrappedHandler.ProcessRequest(context);
        }
    }
}
