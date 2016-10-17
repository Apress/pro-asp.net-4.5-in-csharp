using System;
using System.Web;

namespace Events {
    public class Global : HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            EventCollection.Add(EventSource.Application, "Start");
        }

        protected void Application_End(object sender, EventArgs e) {
            EventCollection.Add(EventSource.Application, "End");
        }

        protected void Application_BeginRequest(object sender, EventArgs e) {
            EventCollection.Add(EventSource.Application, "BeginRequest");
        }

        protected void Application_EndRequest(object sender, EventArgs e) {
            EventCollection.Add(EventSource.Application, "EndRequest");
        }

        protected void Application_PreRequestHandlerExecute(object sender, EventArgs e) {
            EventCollection.Add(EventSource.Application, "PreRequestHandlerExecute");
        }

        protected void Application_PostRequestHandlerExecute(object send, EventArgs e) {
            EventCollection.Add(EventSource.Application, "PostRequestHandlerExecute");
        }
    }
}