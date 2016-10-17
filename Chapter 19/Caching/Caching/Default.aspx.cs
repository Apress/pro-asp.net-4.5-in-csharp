using System;

namespace Caching {
    public partial class Default : System.Web.UI.Page {
        private static readonly string CACHE_KEY = "codebehind_ts";

        protected string GetTime() {
            string ts;
            STCacheObject<string> stObject = Cache[CACHE_KEY] as STCacheObject<string>;
            if (stObject == null) {
                ts = new STCacheObject<string>(CACHE_KEY, GenerateTimeStamp).Data;
            } else {
                ts = stObject.Data + " <b>(Cached)</b>";
            }
            return ts;
        }

        private string GenerateTimeStamp() {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
