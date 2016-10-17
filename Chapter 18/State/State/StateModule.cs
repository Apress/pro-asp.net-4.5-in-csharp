using System.Web;

namespace State {

    public enum City {
        London, Paris, Chicago
    }

    public enum Color {
        Red, Green, Blue
    }

    public class StateModule : IHttpModule {
        
        public void Init(HttpApplication app) {

            app.PostAcquireRequestState += (src, args) => {
                if (app.Context.Session != null 
                        && app.Context.Session.IsNewSession
                        && !app.Context.Session.IsReadOnly) {

                    app.Context.Session["color"] = Color.Green;
                    app.Context.Session["city"] = City.London;
                }
            };
        }

        public void Dispose() {
            // do nothing
        }
    }
}