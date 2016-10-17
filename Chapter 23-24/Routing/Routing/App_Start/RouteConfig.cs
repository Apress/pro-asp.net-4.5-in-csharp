using System.Web.Routing;
using System.Collections.Generic;

namespace Routing {

    public class RouteConfig {

        public static void RegisterRoutes(RouteCollection routes) {
            routes.RouteExistingFiles = true;

            routes.MapPageRoute("default", "", "~/Default.aspx", false,
                null, new RouteValueDictionary { { "direction", new IncomingOnly() } });

            routes.MapPageRoute("calc", "calc/{first}/{operation}/{second}",
                "~/Calc.aspx", false, null, new RouteValueDictionary {
                {"first", "[0-9]*"},{ "second", "[0-9]*"}, 
                    { "operation", "plus|minus"}});


        //    routes.StopASPXRequests();

        //    routes.MapPageRoute("default", "", "~/Default.aspx");

        //    routes.Add("flex1", new Route("generichandler",
        //        new FlexibleRouteHandler { HandlerType = "Routing.GenHandler" }));

        //    routes.Add("flex2", new Route("customhandlerfactory",
        //        new FlexibleRouteHandler {
        //            HandlerType = "Routing.CustomHandlerFactory"
        //        }));

        //    routes.Add("flex3", new Route("customhandler",
        //        new FlexibleRouteHandler { HandlerType = "Routing.CustomHandler" }));


        //    routes.Add("browser", new BrowserRoute("browser",
        //        new Dictionary<Browser, string> {
        //            { Browser.IE10, "~/Calc.aspx"},
        //            { Browser.CHROME, "~/Loop.aspx"},
        //            { Browser.OTHER, "~/Default.aspx"}
        //        }));


        //    routes.Add("apress", new Route("apress", null, null,
        //        new RouteValueDictionary { { "target", "http://apress.com" } },
        //        new RedirectionRouteHandler())); 


        //    routes.MapPageRoute("postTest", "methodtest", "~/PostTest.aspx",
        //        false, null,
        //        new RouteValueDictionary {
        //            {"httpMethod", new HttpMethodConstraint("POST")},
        //            {"city", new FormDataConstraint("London")}
        //        });

        //    routes.Ignore("methodtest",
        //        new { httpMethod = new HttpMethodConstraint("POST") });

        //    routes.MapPageRoute("getTest", "methodtest", "~/GetTest.aspx",
        //        false, null, null);
        }
    }
}
