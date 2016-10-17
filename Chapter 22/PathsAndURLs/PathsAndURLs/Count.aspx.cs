using System.Collections.Generic;
using Microsoft.AspNet.FriendlyUrls;
using Microsoft.AspNet.FriendlyUrls.ModelBinding;

namespace PathsAndURLs {
    public partial class Count : System.Web.UI.Page {

        public IEnumerable<int> GetNumbers([FriendlyUrlSegments(0)] int? max) {
            for (int i = 0; i < (max ?? 5); i++) {
                yield return i;
            }
        }
    }
}
