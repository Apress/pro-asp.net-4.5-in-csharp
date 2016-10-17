using System.Collections.Generic;
using System.Web.Configuration;

namespace ConfigFiles.Admin {
    public partial class FolderForm : System.Web.UI.Page {
        public IEnumerable<string> GetConfig() {

            NewUserDefaultsSection defaults
                = (NewUserDefaultsSection)WebConfigurationManager
                      .GetSection("customDefaults/newUserDefaults");
            yield return string.Format("Defaults: {0}, {1}, {2}, {3}",
                defaults.City, defaults.Country, defaults.Language, defaults.Region);

            PlacesSection places
                = (PlacesSection)WebConfigurationManager
                    .GetSection("customDefaults/places");
            foreach (Place place in places.Places) {
                yield return string.Format("Place: {0}, {1}, {2}",
                    place.Code, place.City, place.Country);
            }
        }
    }
}
