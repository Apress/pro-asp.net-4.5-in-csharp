using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;

namespace ManagingUsers.Admin {

    public class UserDetails {
        public string Name { get; set; }
        public string Roles { get; set; }
        public bool Locked { get; set; }
        public bool Online { get; set; }
    }

    public partial class Manage : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) {
                if (Request["unlock"] != null) {
                    Membership.GetUser(Request["unlock"]).UnlockUser();
                } else if (Request["delete"] != null) {
                    if (Request["delete"] != Membership.GetUser().UserName) {
                        Membership.DeleteUser(Request["delete"]);
                    }
                }
            }
        }

        public IEnumerable<UserDetails> GetUsers() {
            return Membership.GetAllUsers()
                .Cast<MembershipUser>().Select(m => new UserDetails {
                    Name = m.UserName,
                    Roles = String.Join(", ", Roles.GetRolesForUser(m.UserName)),
                    Locked = m.IsLockedOut,
                    Online = m.IsOnline
                });
        }
    }
}