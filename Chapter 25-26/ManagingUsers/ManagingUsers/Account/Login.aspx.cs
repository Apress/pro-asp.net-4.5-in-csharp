using System;
using System.Web.Security;

namespace ManagingUsers.Account {

    public partial class Login : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) {
                string user = Request["user"];
                string pass = Request["pass"];
                string action = Request["action"];
                if (action == "login" && Membership.ValidateUser(user, pass)) {
                    FormsAuthentication.RedirectFromLoginPage(user, false);
                } else {
                    message.Style["visibility"] = "visible";
                }
            } else if (Request.IsAuthenticated) {
                Response.StatusCode = 403;
                Response.SuppressContent = true;
                Context.ApplicationInstance.CompleteRequest();
            }
        }
    }
}
