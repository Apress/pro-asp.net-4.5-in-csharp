using System.Collections.Generic;
using System.Configuration;
using System.Web.Configuration;


namespace ConfigFiles {
    public partial class Default : System.Web.UI.Page {

        public IEnumerable<string> GetConfig() {

            Configuration config
                = WebConfigurationManager.OpenWebConfiguration(Request.Path);

            UserAndPlaceSectionGroup group
                = (UserAndPlaceSectionGroup)config.SectionGroups["customDefaults"];
            PlacesSection places = group.Places;


            Place defaultPlace = places.Places[places.Default];
            yield return string.Format("The default is: {0} (City: {1}, Country: {2})",
                places.Default, defaultPlace.City, defaultPlace.Country);

            foreach (Place p in places.Places) {
                yield return string.Format("{0} {1}", p.City, p.Country);
            }
        }

    }
}
