using System.Web;

namespace Routing {

    public class RouteTestModule : IHttpModule {

        public void Init(HttpApplication app) {
            app.BeginRequest += (src, args) => {
                app.Context.Items["routePath"] = app.Request.CurrentExecutionFilePath;
                app.Server.Execute("/RouteTest.aspx");
            };
        }

        public void Dispose() {
            // do nothing
        }
    }
}
