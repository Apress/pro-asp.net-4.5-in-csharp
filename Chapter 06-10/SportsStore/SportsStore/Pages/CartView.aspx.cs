using System;
using System.Collections.Generic;
using SportsStore.Models;
using SportsStore.Pages.Helpers;
using SportsStore.Models.Repository;
using System.Linq;
using System.Web.Routing;

namespace SportsStore.Pages {
    public partial class CartView : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack) {
                Repository repo = new Repository();
                int productId;
                if (int.TryParse(Request.Form["remove"], out productId)) {
                    Product productToRemove = repo.Products
                        .Where(p => p.ProductID == productId).FirstOrDefault();
                    if (productToRemove != null) {
                        SessionHelper.GetCart(Session).RemoveLine(productToRemove);
                    }
                }
            }
        }

        public IEnumerable<CartLine> GetCartLines() {
            return SessionHelper.GetCart(Session).Lines;
        }

        public decimal CartTotal {
            get {
                return SessionHelper.GetCart(Session).ComputeTotalValue();
            }
        }

        public string ReturnUrl {
            get {
                return SessionHelper.Get<string>(Session, SessionKey.RETURN_URL);
            }
        }

        public string CheckoutUrl {
            get {
                return RouteTable.Routes.GetVirtualPath(null, "checkout",
                    null).VirtualPath;
            }
        }
    }
}
