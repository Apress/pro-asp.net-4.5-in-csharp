using System;
using System.Web;

namespace Events {
    public class ParamsModule : IHttpModule {

        public void Init(HttpApplication app) {

            app.PostAuthenticateRequest += (src, args) => {
                if (app.Request.Url.LocalPath == "/Params.aspx" &&
                        !app.User.Identity.IsAuthenticated) {
                    app.Context.AddError(new UnauthorizedAccessException());
                }
            };
        }

        public void Dispose() {
        }
    }
}
