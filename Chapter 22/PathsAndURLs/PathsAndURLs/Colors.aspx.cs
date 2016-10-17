using System.Collections.Generic;
using Microsoft.AspNet.FriendlyUrls;

namespace PathsAndURLs {
    public partial class Colors : System.Web.UI.Page {

        public IEnumerable<string> GetColors() {
            return Request.GetFriendlyUrlSegments();
        }
    }
}
