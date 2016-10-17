using System;
using System.Web;
using System.Web.Caching;

namespace Caching {

    public class RequestEventMapModule : IHttpModule {
        public event EventHandler BeginRequest;

        public void Init(HttpApplication app) {
            app.BeginRequest += (src, args) => {
                if (BeginRequest != null) {
                    BeginRequest(this, EventArgs.Empty);
                }
            };
        }

        public void Dispose() {
            // do nothing
        }
    }

    public class RequestCountDependency : CacheDependency {
        private int requestLimit, requestCount;

        public RequestCountDependency(int limit) {
            requestLimit = limit;
            requestCount = 0;
            configureEventHandler(true);
            FinishInit();
        }

        private void configureEventHandler(bool attach) {
            if (HttpContext.Current != null) {
                RequestEventMapModule module =
                    HttpContext.Current.ApplicationInstance
                        .Modules["RequestEventMap"]
                      as RequestEventMapModule;
                if (module != null) {
                    if (attach) {
                        module.BeginRequest += HandleEvent;
                    } else {
                        module.BeginRequest -= HandleEvent;
                    }
                }
            }
        }

        private void HandleEvent(object src, EventArgs args) {
            if (++requestCount > requestLimit) {
                NotifyDependencyChanged(this, EventArgs.Empty);
            }
        }

        protected override void DependencyDispose() {
            configureEventHandler(false);
            base.DependencyDispose();
        }
    }
}
