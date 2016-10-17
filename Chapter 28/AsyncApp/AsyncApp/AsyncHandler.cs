using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace AsyncApp {
    public class AsyncHandler : HttpTaskAsyncHandler {

        public override async Task ProcessRequestAsync(HttpContext context) {
            string webResponse
                = await new WebClient().DownloadStringTaskAsync("http://asp.net");
            context.Response.ContentType = "text/plain";
            context.Response.Write(string.Format("The length of the result is: {0}",
                webResponse.Length));
        }
    }
}
