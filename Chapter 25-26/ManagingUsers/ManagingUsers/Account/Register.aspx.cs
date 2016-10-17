using System;
using System.Web.Security;

namespace ManagingUsers.Account {
    public partial class Register : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            if (IsPostBack) {
                string username = Request["user"];
                string password = Request["pass"];
                string email = Request["email"];
                string question = Request["question"];
                string answer = Request["answer"];

                if (username == "" || password == "" || email == "" || answer == "") {
                    ReportError("All fields must be filled");
                } else {
                    MembershipCreateStatus status;
                    MembershipUser user = Membership.CreateUser(username, password,
                        email, question, answer, true, out status);

                    if (status == MembershipCreateStatus.Success) {
                        Roles.AddUserToRole(username, "users");
                        FormsAuthentication.SetAuthCookie(username, false);
                        Response.Redirect("/");
                    } else {
                        ReportError(status.ToString());
                    }
                }
            }
        }

        protected void ReportError(string errorMsg) {
            message.InnerText = "Error: " + errorMsg;
            error.Visible = true;
        }
    }
}
