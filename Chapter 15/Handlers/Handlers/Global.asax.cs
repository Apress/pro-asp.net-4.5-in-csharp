using System;

namespace Handlers {
    public class Global : System.Web.HttpApplication {

        public Global() {
            MapRequestHandler += HandleEvent;
            PostMapRequestHandler += HandleEvent;
            PreRequestHandlerExecute += HandleEvent;
            PostRequestHandlerExecute += HandleEvent;
        }

        private void HandleEvent(object sender, EventArgs e) {
            string eventType = Context.CurrentNotification.ToString();
            if (Context.IsPostNotification) {
                eventType = "Post" + eventType;
            }

            System.Diagnostics.Debug.WriteLine("Request Event: {0}",
                new[] { eventType });
        }
    }
}