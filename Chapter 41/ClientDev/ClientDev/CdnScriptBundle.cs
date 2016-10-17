using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Optimization;

namespace ClientDev {
    public class CdnScriptBundle : ScriptBundle {

        public CdnScriptBundle(string path)
            : base(path) {
        }

        public Bundle CdnInclude(string filePath, string cdnPath) {
            Bundle result = base.Include(filePath);

            BundleContext ctx = new BundleContext(
                new HttpContextWrapper(HttpContext.Current),
                BundleTable.Bundles, Path);

            Regex regexp = new Regex(@"(\d+(?:\.\d+){1,3})", RegexOptions.IgnoreCase);
            string version = regexp.Match(EnumerateFiles(ctx).First().Name).Value;
            CdnPath = cdnPath.Replace("{version}", version);
            return result;
        }
    }
}
