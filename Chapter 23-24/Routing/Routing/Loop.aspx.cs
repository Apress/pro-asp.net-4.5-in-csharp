using System.Collections.Generic;
using System.Web.ModelBinding;

namespace Routing {
    public partial class Loop : System.Web.UI.Page {

        public IEnumerable<int> GetValues([RouteData("count")] int? count) {
            for (int i = 0; i < (count ?? 3); i++) {
                yield return i;
            }
        }
    }
}
