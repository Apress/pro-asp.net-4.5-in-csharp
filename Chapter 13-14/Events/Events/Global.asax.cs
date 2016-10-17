using System;
using System.Web;

namespace Events {
    public class Global : System.Web.HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            EventCollection.Add(EventSource.Application, "Start");
            Application["message"] = "Application Events";
        }

        protected void Application_End(object sender, EventArgs e) {
            EventCollection.Add(EventSource.Application, "End");
        }

        public void AverageTime_NewAverage(object src, AverageTimeEventArgs args) {
            Response.Write(string.Format("<h3>Ave time: {0:F2}ms</h3>",
                args.AverageTime));
        }

    }
}
