using System;
using System.Web;

namespace Handlers {

    public class TotalDurationHandlerArgs : EventArgs {
        public double TotalTime { get; set; }
        public int Requests { get; set; }
    }

    public class TotalDurationModule : IHttpModule {
        private double totalTime = 0;
        private int requestCount = 0;

        public void Init(HttpApplication app) {
            app.PreRequestHandlerExecute += HandleEvent;
            app.PostRequestHandlerExecute += HandleEvent;
        }

        private void HandleEvent(object src, EventArgs args) {
            HttpContext context = ((HttpApplication)src).Context;
            if (!context.IsPostNotification) {
                context.Items["total_time"] = totalTime;
            } else if (context.Handler is IRequiresDurationData) {
                totalTime = (double)context.Items["total_time"];
                requestCount++;
                System.Diagnostics.Debug.WriteLine(
                    string.Format("Total Duration is {0}ms for {1} requests",
                        totalTime, requestCount));
            }
        }

        public void Dispose() {
            // nothing to do
        }
    }
}
