using System;
using System.Web;
using System.Web.Routing;

namespace Routing {
    public class FlexibleRouteHandler : IRouteHandler {

        public string HandlerType { get; set; }

        public IHttpHandler GetHttpHandler(RequestContext requestContext) {
            IHttpHandler handler = null;

            if (HandlerType != null) {
                object target = Activator.CreateInstance(Type.GetType(HandlerType));
                if (target is IHttpHandlerFactory
                        && requestContext.HttpContext is HttpContextWrapper) {

                    handler = (target as IHttpHandlerFactory).GetHandler(
                        HttpContext.Current,
                        requestContext.HttpContext.Request.RequestType,
                        requestContext.HttpContext.Request.RawUrl,
                        requestContext.HttpContext.Request.PhysicalApplicationPath);

                } else if (target is IHttpHandler) {
                    handler = target as IHttpHandler;
                }
            }
            return handler;
        }
    }
}
