using System.IO;
using System.Web;

namespace ClientDev {
    public class MobileModule : IHttpModule {

        public void Init(HttpApplication context) {
            context.BeginRequest += (src, args) => {
                string requested = context.Request.Path;
                if (requested.ToLower().EndsWith(".aspx")
                        && !requested.ToLower().EndsWith(".mobile.aspx")
                        && context.Request.Browser.IsMobileDevice) {
                    string[] pathElems = requested.Split('.');
                    pathElems[pathElems.Length - 1] = "Mobile.aspx";
                    string target = string.Join(".", pathElems);
                    if (File.Exists(context.Request.MapPath(target))) {
                        context.Server.Transfer(target);
                    }
                }
            };
        }

        public void Dispose() {
            // do nothing
        }
    }
}
