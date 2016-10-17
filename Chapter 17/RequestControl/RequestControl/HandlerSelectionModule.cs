using System.Web;

namespace RequestControl {

    public class HandlerSelectionModule : IHttpModule {

        public void Init(HttpApplication app) {
            app.PostResolveRequestCache += (src, args) => {
                if (app.Request.RequestType == "POST") {
                    switch (app.Request.Form["choice"]) {
                        case "remaphandler":
                            app.Context.RemapHandler(new CurrentTimeHandler());
                            break;
                        case "execute":
                            string[] paths = { "Default.aspx", "SecondPage.aspx" };
                            foreach (string path in paths) {
                                app.Response.Write(string.Format(
                                    "<div>This is the {0}response</div>", path));
                                app.Server.Execute(path);
                            }
                            app.CompleteRequest();
                            break;

                    }
                }
            };

        }

        public void Dispose() {
            // do nothing
        }
    }
}
