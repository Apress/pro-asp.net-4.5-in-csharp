using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;

namespace PartyInvites {
    public partial class Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            if (IsPostBack) {
                GuestResponse rsvp = new GuestResponse();

                if (TryUpdateModel(rsvp, new FormValueProvider(ModelBindingExecutionContext))) {
                    ResponseRepository.GetRepository().AddResponse(rsvp);
                    if (rsvp.WillAttend.HasValue && rsvp.WillAttend.Value) {
                        Response.Redirect("seeyouthere.html");
                    } else {
                        Response.Redirect("sorryyoucantcome.html");
                    }
                }
            }
        }
    }
}