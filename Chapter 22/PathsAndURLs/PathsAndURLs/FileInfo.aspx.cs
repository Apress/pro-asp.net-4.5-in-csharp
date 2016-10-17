using System.IO;

namespace PathsAndURLs {
    public partial class FileInfo : System.Web.UI.Page {

        protected string GetFileContent() {
            string path = "/Content/Colors.html";
            string file = Request.MapPath(path);
            return File.ReadAllText(file);
        }
    }
}
