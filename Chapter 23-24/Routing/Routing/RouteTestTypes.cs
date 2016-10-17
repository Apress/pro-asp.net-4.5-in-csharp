using System.Web;

namespace Routing {

    public class ContextMapper : HttpContextBase {
        private RequestMapper requestMapper;

        public ContextMapper(string path) {
            requestMapper = new RequestMapper(path);
        }

        public override HttpRequestBase Request {
            get { return requestMapper; }
        }
    }

    public class RequestMapper : HttpRequestBase {
        private string requestPath;

        public RequestMapper(string path) {
            requestPath = VirtualPathUtility.ToAppRelative(path);
        }

        public override string AppRelativeCurrentExecutionFilePath {
            get { return requestPath; }
        }

        public override string PathInfo {
            get { return ""; }
        }
    }
}
