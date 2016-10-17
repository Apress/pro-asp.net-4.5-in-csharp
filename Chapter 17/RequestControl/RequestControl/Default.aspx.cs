using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RequestControl {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) {
                switch (Request.Form["choice"]) {
                    case "redirect302":
                        Response.Redirect("/SecondPage.aspx", false);
                        break;
                    case "redirect301":
                        //Response.RedirectPermanent("/CurrentTimeHandler.ashx");
                        Response.RedirectLocation = "/CurrentTimeHandler.ashx";
                        Response.StatusCode = 301;
                        Context.ApplicationInstance.CompleteRequest();
                        break;
                    case "transferpage":
                        Server.Transfer("/SecondPage.aspx");
                        break;

                }
            }

        }
    }
}