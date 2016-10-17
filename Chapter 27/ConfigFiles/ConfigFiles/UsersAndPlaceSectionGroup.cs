using System.Configuration;

namespace ConfigFiles {
    public class UserAndPlaceSectionGroup : ConfigurationSectionGroup {

        [ConfigurationProperty("newUserDefaults")]
        public NewUserDefaultsSection NewUserDefaults {
            get { return (NewUserDefaultsSection)Sections["newUserDefaults"]; }
        }

        [ConfigurationProperty("places")]
        public PlacesSection Places {
            get { return (PlacesSection)Sections["places"]; }
        }
    }
}
