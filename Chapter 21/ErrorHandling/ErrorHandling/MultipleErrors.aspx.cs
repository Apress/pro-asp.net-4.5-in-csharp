using System.Collections.Generic;
using System.Linq;

namespace ErrorHandling {
    public partial class MultipleErrors : System.Web.UI.Page {

        public IEnumerable<string> GetErrorMessages() {
            return Context.AllErrors.Select(e => e.Message);
        }
    }
}
