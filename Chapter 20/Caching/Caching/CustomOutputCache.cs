using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Web.Caching;

namespace Caching {

    class CacheItem {
        public object Data { get; set; }
        public DateTime Expiry { get; set; }
        public bool Expired {
            get {
                return DateTime.UtcNow > Expiry;
            }
        }
    }

    public class CustomOutputCache : OutputCacheProvider {
        private ConcurrentDictionary<string, CacheItem> cache;

        public CustomOutputCache()
            : base() {
            cache = new ConcurrentDictionary<string, CacheItem>();
        }

        public override object Add(string key, object entry, DateTime utcExpiry) {
            if (cache.ContainsKey(key) && !cache[key].Expired) {
                Debug.WriteLine(string.Format("Add: Cache already contains item: {0}",
                    key));
                return Get(key);
            } else {
                Debug.WriteLine(string.Format("Add: Adding new item: {0}", key));
                Set(key, entry, utcExpiry);
                return entry;
            }
        }

        public override void Remove(string key) {
            Debug.WriteLine(string.Format("Remove: {0}", key));
            if (cache.ContainsKey(key)) {
                cache[key] = null;
            }
        }

        public override object Get(string key) {
            if (cache.ContainsKey(key)) {
                CacheItem item = cache[key];
                if (!item.Expired) {
                    Debug.WriteLine(string.Format("Get: Cache contains item: {0}", key));
                    return item.Data;
                } else {
                    Debug.WriteLine(string.Format("Get: Expired item: {0}", key));
                }
            } else {
                Debug.WriteLine(string.Format("Get: No item: {0}", key));
            }
            return null;
        }

        public override void Set(string key, object entry, DateTime utcExpiry) {
            Debug.WriteLine(string.Format("Set: {0}", key));
            cache[key] = new CacheItem {
                Data = entry,
                Expiry = utcExpiry
            };
        }
    }
}
