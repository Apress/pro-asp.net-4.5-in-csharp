using System;
using System.IO;
using System.Web.Caching;

namespace Caching {

    public partial class CitiesControl : System.Web.UI.UserControl {
        private static readonly string fileName = "/CitiesList.html";
        private static readonly string TIME_CACHE_KEY = "cities_time";
        private static readonly string HTML_CACHE_KEY = "cities_html";
        private bool cached = false;

        public string GetCities() {
            string html = (string)Cache[HTML_CACHE_KEY];
            if (html == null) {
                html = File.ReadAllText(MapPath(fileName));

                AggregateCacheDependency aggDep = new AggregateCacheDependency();
                aggDep.Add(new CacheDependency(MapPath(fileName)));
                aggDep.Add(new RequestCountDependency(3));

                Cache.Insert(HTML_CACHE_KEY, html, aggDep);

            } else {
                cached = true;
            }
            return html;
        }


        protected string GetTimeStamp() {
            string timeStamp = (string)Cache[TIME_CACHE_KEY];
            if (timeStamp == null) {
                timeStamp = DateTime.Now.ToLongTimeString();
                Cache.Insert(TIME_CACHE_KEY, timeStamp,
                    new CacheDependency(null, new string[] { HTML_CACHE_KEY }));
            }
            return timeStamp + (cached ? " <b>Cached</b>" : "");
        }
    }
}
