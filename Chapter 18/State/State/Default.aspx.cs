using System;

using System.Web;


namespace State {
    public partial class Default : System.Web.UI.Page {
        private int counter;

        protected void Page_Load(object src, EventArgs e) {
            HttpCookie incomingCookie = Request.Cookies["counter"];
            counter = incomingCookie == null ? 0 : int.Parse(incomingCookie.Value);            
            counter++;
            Response.Cookies.Add(new HttpCookie("counter", counter.ToString()));
                
               
            //counter = (int)(ViewState["counter"] ?? 0);
            //ViewState["counter"] = ++counter;
        }        

        protected int GetCounter() {
            return counter;
        }
    }
}