using System.Web;
using System.Web.Optimization;
using System.Web.UI;

//namespace ClientDev.App_Start {
namespace ClientDev {
    public class BundleConfig {

        public static void RegisterBundles(BundleCollection bundles) {

            Bundle jquery = new CdnScriptBundle("~/bundle/jquery")
                .CdnInclude("~/Scripts/jquery-{version}.js",
                    "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-{version}.min.js");

            Bundle jqueryui = new ScriptBundle("~/bundle/jqueryui");
            jqueryui.CdnPath =
                "http://ajax.aspnetcdn.com/ajax/jquery.ui/1.10.2/jquery-ui.min.js";
            jqueryui.Include("~/Scripts/jquery-ui-{version}.js");

            Bundle basicStyles = new StyleBundle("~/bundle/basicCSS")
                    .Include("~/MainStyles.css", "~/ErrorStyles.css");

            Bundle jqueryUIStyles = new StyleBundle("~/Content/themes/base/jqueryUICSS")
                    .IncludeDirectory("~/Content/themes/base", "*.css");

            bundles.UseCdn = true;

            ScriptManager.ScriptResourceMapping.AddDefinition("jquery",
                new ScriptResourceDefinition { Path = "~/bundles/jquery" });

            bundles.Add(jquery);
            bundles.Add(jqueryui);
            bundles.Add(basicStyles);
            bundles.Add(jqueryUIStyles);
        }
    }
}
