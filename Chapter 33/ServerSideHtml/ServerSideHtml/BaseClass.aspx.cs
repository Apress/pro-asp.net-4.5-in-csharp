using System;
using System.Diagnostics;

namespace ServerSideHtml {
    public partial class BaseClass : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            userInput.Attributes["class"] = "user";

            foreach (string key in userInput.Attributes.Keys) {
                Debug.WriteLine("Attribute {0}: {1}", key, userInput.Attributes[key]);
            }

            Debug.WriteLine(string.Format("Tag Name: {0}", userInput.TagName));
        }
    }
}
