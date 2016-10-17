using System;
using System.Web.Optimization;
using System.Web.UI;

namespace Data {
    public class Global : System.Web.HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
