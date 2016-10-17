using System;
using System.Web;
using System.Web.Caching;

namespace Caching {
    public class STCacheObject<T> {
        private int accessedCounter = 0;
        private int renewTheshold;
        private int renewDurationMins;
        private T dataObject;
        private Func<T> updateCallback;

        public STCacheObject(string key, Func<T> callback, int threshold = 100,
            int duration = 60) {

            updateCallback = callback;
            dataObject = updateCallback();
            renewTheshold = threshold;
            renewDurationMins = duration;

            HttpContext.Current.Cache.Insert(key, this, null,
                Expiry, Cache.NoSlidingExpiration, HandleUpdateCallback);
        }

        public T Data {
            get {
                accessedCounter++;
                return dataObject;
            }
        }

        public DateTime Expiry {
            get {
                return DateTime.Now.AddSeconds(10);
            }
        }

        public void AddToCache(Cache cache, string key) {

        }

        public void HandleUpdateCallback(string key, CacheItemUpdateReason reason,
                out object data, out CacheDependency dependency,
                out DateTime absExpiry, out TimeSpan slidingExpiry) {

            bool renew = accessedCounter >= renewTheshold;
            if (renew) {
                dataObject = updateCallback();
                accessedCounter = 0;
            }

            data = renew ? this : null;
            dependency = null;
            slidingExpiry = Cache.NoSlidingExpiration;
            absExpiry = renew ? Expiry : Cache.NoAbsoluteExpiration;
        }
    }
}
