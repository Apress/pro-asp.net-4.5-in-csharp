using System.Collections.Concurrent;
using System.Web;

namespace Handlers {
    public class RecyclingFactory : IHttpHandlerFactory {
        private BlockingCollection<RecylingHandler> pool
            = new BlockingCollection<RecylingHandler>();
        private int handler_count = 0;
        private int handler_limit = 100;
        private int totalRequests = 0;

        public IHttpHandler GetHandler(HttpContext context, string requestType,
                string url, string pathTranslated) {

            totalRequests++;
            RecylingHandler handler;
            if (!pool.TryTake(out handler)) {
                if (handler_count < handler_limit) {
                    handler_count++;
                    handler = new RecylingHandler(this, handler_count);
                    pool.Add(handler);
                } else {
                    handler = pool.Take();
                }
            }
            handler.RequestCount++;
            return handler;
        }

        public void ReleaseHandler(IHttpHandler handler) {
            if (handler.IsReusable) {
                pool.Add((RecylingHandler)handler);
            }
        }

        public int TotalRequests {
            get { return totalRequests; }
        }
    }

    public class RecylingHandler : IHttpHandler {
        private int handlerID;
        private RecyclingFactory factory;

        public RecylingHandler(RecyclingFactory f, int id) {
            factory = f;
            handlerID = id;
        }

        public int RequestCount { get; set; }

        public void ProcessRequest(HttpContext context) {
            context.Response.ContentType = "text/plain";
            context.Response.Write(string.Format
                ("Total requests: {0}, HandlerID: {1}, Handler Requests {2}",
                factory.TotalRequests, handlerID, RequestCount));
        }

        public bool IsReusable {
            get { return RequestCount < 4; }
        }
    }
}
