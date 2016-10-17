using System;
using System.Diagnostics;

namespace ErrorHandling {

    public enum Failure {
        None,
        Database,
        FileSystem,
        Network
    }

    public class Global : System.Web.HttpApplication {

        //protected void Application_EndRequest(object sender, EventArgs e) {
        //    if (Context.AllErrors != null && Context.AllErrors.Length > 1) {
        //        Response.ClearHeaders();
        //        Response.ClearContent();
        //        Response.StatusCode = 200;
        //        Server.Execute("/MultipleErrors.aspx");
        //        Context.ClearError();
        //    }
        //}

        //protected void Application_Error(object sender, EventArgs e) {
        //    Failure failReason = CheckForRootCause();
        //    if (failReason != Failure.None) {

        //        Response.ClearHeaders();
        //        Response.ClearContent();
        //        Response.StatusCode = 200;

        //        Server.Execute(string.Format
        //            ("/ComponentError.aspx?errorSource={0}&errorType={1}",
        //            "the " + failReason.ToString().ToLower(),
        //            Context.Error.GetType()));

        //        Context.ClearError();
        //    }
        //}


        //private Failure CheckForRootCause() {
        //    // get results of latest health checks
        //    Array values = Enum.GetValues(typeof(Failure));
        //    return (Failure)values.GetValue(new Random().Next(values.Length));
        //}
    }
}
