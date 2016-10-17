using System;
using System.Globalization;
using System.Threading;
using System.Web;

namespace Events {
    public class LocaleModule : IHttpModule {

        public void Init(HttpApplication app) {
            app.BeginRequest += HandleEvent;
        }

        protected void HandleEvent(object src, EventArgs args) {
            string[] langs = ((HttpApplication)src).Request.UserLanguages;

            if (langs != null && langs.Length > 0 && langs[0] != null) {
                try {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(langs[0]);
                    //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
                } catch { }
            }
        }

        public void Dispose() {
        }
    }
}
