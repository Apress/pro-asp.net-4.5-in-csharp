using System;
using System.Web.Security;

namespace ManagingUsers {

    public partial class Auth : System.Web.UI.MasterPage {

        protected void Page_Load(object src, EventArgs args) {
            if (!IsPostBack) {
                if (Request.IsAuthenticated) {
                    authAction.InnerText = "Log Out";
                } else {
                    authGreeting.Visible = false;
                    authAction.InnerText = "Log In";
                }
            } else if (IsPostBack && Request["authAction"] == "auth") {
                if (Request.IsAuthenticated) {
                    FormsAuthentication.SignOut();
                    Response.Redirect(Request.Path);
                } else {
                    FormsAuthentication.RedirectToLoginPage();
                }
            }
        }

        protected string GetGreeting() {
            return String.Format("Hello, {0}!", Context.User.Identity.Name);
        }
    }
}
