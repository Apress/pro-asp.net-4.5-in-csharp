using System;
using System.Web;

namespace CommonModules {

    public class TimerEventArgs : EventArgs {
        public double Duration { get; set; }
    }

    public class TimerModule : IHttpModule {
        private DateTime startTime;
        public event EventHandler<TimerEventArgs> RequestTimed;

        public void Init(HttpApplication app) {
            app.BeginRequest += HandleEvent;
            app.EndRequest += HandleEvent;
        }

        private void HandleEvent(object src, EventArgs args) {
            HttpApplication app = src as HttpApplication;
            switch (app.Context.CurrentNotification) {
                case RequestNotification.BeginRequest:
                    startTime = app.Context.Timestamp;
                    break;
                case RequestNotification.EndRequest:
                    double elapsed = DateTime.Now.Subtract(startTime).TotalMilliseconds;
                    System.Diagnostics.Debug.WriteLine(
                      string.Format("Duration: {0} {1}ms", app.Request.RawUrl, elapsed));
                    if (RequestTimed != null) {
                        RequestTimed(this, new TimerEventArgs { Duration = elapsed });
                    }
                    break;
            }
        }

        public void Dispose() {
            // nothing to do
        }
    }
}
