using System;
using System.IO;
using System.Web;
using System.Web.Caching;
using System.Web.Compilation;

namespace Caching {

    public class CachingHandlerFactory : IHttpHandlerFactory {

        public IHttpHandler GetHandler(HttpContext context, string requestType,
                string url, string pathTranslated) {

            string response = GetFromCache(context, pathTranslated);
            if (response == null) {
                IHttpHandler handler = BuildManager.CreateInstanceFromVirtualPath(
                    context.Request.Path, typeof(IHttpHandler)) as IHttpHandler;

                StringWriter sr = new StringWriter();
                context.Server.Execute(new PageWrapper(handler), sr, true);
                response = sr.ToString();
                AddToCache(context, pathTranslated, response);
            }
            return new CachedResponseHandler(response);
        }

        private void AddToCache(HttpContext context, string path, string output) {
            OutputCacheProvider oc =
                OutputCache.Providers[OutputCache.DefaultProviderName];
            if (oc != null) {
                oc.Add(path, output, DateTime.Now.AddSeconds(60));
            } else {
                context.Cache.Add(path, output, null, DateTime.Now.AddSeconds(60),
                    Cache.NoSlidingExpiration, CacheItemPriority.Low, null);
            }
        }

        private string GetFromCache(HttpContext context, string path) {
            OutputCacheProvider oc =
                OutputCache.Providers[OutputCache.DefaultProviderName];
            if (oc != null) {
                return oc.Get(path) as string;
            } else {
                return context.Cache.Get(path) as string;
            }
        }

        public void ReleaseHandler(IHttpHandler handler) {
            // not used
        }
    }
}
