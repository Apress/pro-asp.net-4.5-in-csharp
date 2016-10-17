using System.Web;

namespace RequestControl {

    public class RequestedFileInfo {
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class AjaxSourceModule : IHttpModule {

        public void Init(HttpApplication app) {
            app.BeginRequest += (src, args) => {
                if (IsAjaxRequest(app.Request) &&
                    app.Request.CurrentExecutionFilePathExtension == ".src") {

                    string reqFilePath = app.Request.FilePath;
                    reqFilePath = reqFilePath.Substring(0, reqFilePath.LastIndexOf('.'));

                    app.Context.Items["fileInfo"] = new RequestedFileInfo {
                        Name = reqFilePath,
                        Path = app.Request.MapPath(reqFilePath)
                    };

                    app.Context.RemapHandler(new AjaxSourceHandler());
                }
            };
        }

        private bool IsAjaxRequest(HttpRequest request) {
            return request.Headers["X-Requested-With"] == "XMLHttpRequest"
                || request["X-Requested-With"] == "XMLHttpRequest";
        }

        public void Dispose() {
            // do nothing
        }
    }

    public class AjaxSourceHandler : IHttpHandler {

        public void ProcessRequest(HttpContext context) {

            RequestedFileInfo fileInfo = (RequestedFileInfo)context.Items["fileInfo"];

            string response = string.Format("{{\"name\":\"{0}\", \"path\":\"{1}\"}}",
                fileInfo.Name, fileInfo.Path);
            context.Response.ContentType = "application/json";
            context.Response.Write(response);
        }

        public bool IsReusable {
            get { return false; }
        }
    }
}
