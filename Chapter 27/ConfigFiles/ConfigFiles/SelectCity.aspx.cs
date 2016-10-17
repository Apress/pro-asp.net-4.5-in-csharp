using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;

namespace ConfigFiles {
    public partial class SelectCity : System.Web.UI.Page {

        public IEnumerable<Place> GetPlaces() {
            return ((PlacesSection)WebConfigurationManager
                .GetWebApplicationSection("customDefaults/places"))
                .Places.Cast<Place>();
        }
    }
}
