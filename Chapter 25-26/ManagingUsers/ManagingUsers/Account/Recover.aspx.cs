using System;
using System.Web.Security;

namespace ManagingUsers.Account {
    public partial class Recover : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) {
                if (task.Value == "Next") {
                    MembershipUser mUser = Membership.GetUser(Request["user"]);
                    if (mUser != null) {
                        question.Visible = true;
                        questionLabel.InnerText = mUser.PasswordQuestion;
                        if (Request["answer"] != null) {
                            try {
                                string newPassword = mUser.ResetPassword(Request["answer"]);
                                Session["oldpass"] = newPassword;
                                FormsAuthentication.SetAuthCookie(mUser.UserName, false);
                                Response.Redirect("/Account/Change.aspx");
                                //username.Visible = false;
                                //question.Visible = false;
                                //newpass.Visible = true;
                                //password.InnerText = newPassword;
                                //task.Value = "Log In";
                            } catch (MembershipPasswordException) {
                                ReportError("Wrong answer");
                            }
                        }
                    } else {
                        ReportError("Unknown username");
                    }
                } else if (task.Value == "Restart") {
                    Response.Redirect(Request.Path);
                } else {
                    Response.Redirect(FormsAuthentication.LoginUrl);
                }
            }
        }

        protected void ReportError(string errorMsg) {
            message.InnerText = "Error: " + errorMsg;
            error.Visible = true;
            task.Value = "Restart";
        }
    }
}
