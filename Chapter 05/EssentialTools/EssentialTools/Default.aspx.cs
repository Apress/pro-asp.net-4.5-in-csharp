using System;
using System.Web.ModelBinding;

namespace EssentialTools {

    public partial class Default : System.Web.UI.Page {

        public class FormData {
            public string Name { get; set; }
            public string City { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e) {

            if (IsPostBack) {
                
                FormData dataObject = new FormData();

                if (TryUpdateModel(dataObject, 
                        new FormValueProvider(ModelBindingExecutionContext))) {

                            //if (dataObject.Name == "Bob") {
                            //    System.Diagnostics.Debugger.Break();
                            //}

                    target.InnerText = String.Format("Name: {0}, City: {1}",
                        dataObject.Name, dataObject.City);
                }
            }
        }
    }
}