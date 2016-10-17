using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Web.UI;

namespace AsyncApp {

    public class WebSiteResult {
        public string Url { get; set; }
        public long Length { get; set; }
        public long Blocked { get; set; }
        public long Total { get; set; }
    }

    public partial class Default : System.Web.UI.Page {
        private WebSiteResult result;

        protected void Page_Load(object sender, EventArgs e) {
            string targetUrl = "http://asp.net";
            WebClient client = new WebClient();
            result = new WebSiteResult { Url = targetUrl };
            Stopwatch sw = Stopwatch.StartNew();
            RegisterAsyncTask(new PageAsyncTask(async () => {
                string webContent = await client.DownloadStringTaskAsync(targetUrl);
                result.Length = webContent.Length;
                result.Total
                    = (long)DateTime.Now.Subtract(Context.Timestamp).TotalMilliseconds;
            }));
            result.Blocked = sw.ElapsedMilliseconds;
        }


        public WebSiteResult GetResult() {
            return result;
        }
    }
}
