using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Web.UI;
using System.Threading.Tasks;

namespace AsyncApp {

    public class MultiWebSiteResult {
        public string Url { get; set; }
        public long Length { get; set; }
        public long StartTime { get; set; }
    }

    public partial class Multiples : System.Web.UI.Page {
        private ConcurrentQueue<MultiWebSiteResult> results;

        protected void Page_Load(object sender, EventArgs e) {
            string[] targetUrls
                = { "http://asp.net", "http://apress.com", "http://amazon.com" };
            results = new ConcurrentQueue<MultiWebSiteResult>();

            RegisterAsyncTask(new PageAsyncTask(async () => {
                List<Task> tasks = new List<Task>();
                foreach (string targetUrl in targetUrls) {
                    tasks.Add(Task.Factory.StartNew(() => {
                        MultiWebSiteResult result = new MultiWebSiteResult { Url = targetUrl };
                        result.StartTime
                            = (long)DateTime.Now.Subtract(Context.Timestamp).TotalMilliseconds;
                        Task<string> innerTask
                            = new WebClient().DownloadStringTaskAsync(targetUrl);
                        innerTask.Wait();
                        result.Length = innerTask.Result.Length;
                        results.Enqueue(result);
                    }));
                }
                await Task.WhenAll(tasks);
                rep.DataBind();
            }));
        }


        public IEnumerable<MultiWebSiteResult> GetResults() {
            return results;
        }
    }
}
