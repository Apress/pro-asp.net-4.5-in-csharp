using System;
using System.Web.SessionState;
using SportsStore.Models;

namespace SportsStore.Pages.Helpers {

    public enum SessionKey {
        CART,
        RETURN_URL
    }

    public static class SessionHelper {

        public static void Set(HttpSessionState session, SessionKey key, object value) {
            session[Enum.GetName(typeof(SessionKey), key)] = value;
        }

        public static T Get<T>(HttpSessionState session, SessionKey key) {
            object dataValue = session[Enum.GetName(typeof(SessionKey), key)];
            if (dataValue != null && dataValue is T) {
                return (T)dataValue;
            } else {
                return default(T);
            }
        }

        public static Cart GetCart(HttpSessionState session) {
            Cart myCart = Get<Cart>(session, SessionKey.CART);
            if (myCart == null) {
                myCart = new Cart();
                Set(session, SessionKey.CART, myCart);
            }
            return myCart;
        }
    }
}
