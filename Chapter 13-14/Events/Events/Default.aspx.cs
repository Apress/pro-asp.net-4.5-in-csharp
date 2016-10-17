using System;
using System.Collections.Generic;

namespace Events {
    public partial class Default : System.Web.UI.Page {

        public IEnumerable<EventDescription> GetEvents() {
            return EventCollection.Events;
        }
    }
}
