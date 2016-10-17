using System.Web;

namespace Caching {
    public class CachedResponseHandler : IHttpHandler {
        private string cachedResponse;

        public CachedResponseHandler(string response) {
            cachedResponse = response;
        }

        public void ProcessRequest(HttpContext context) {
            context.Response.Write(cachedResponse);
        }

        public bool IsReusable {
            get { return false; }
        }
    }
}
