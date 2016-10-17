using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected string GetMessage() {
            Product[] products = {            
                new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
                new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
                new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
                new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
            };

            var totalPrice = products.OrderByDescending(e => e.Price)
                                .Take(3)
                                .Select(e => e.Price)
                                .Sum(e => e);

            products[2] = new Product { Name = "Stadium", Price = 79600M };

            return String.Format("Total: {0}", totalPrice.ToString());
        }
    }
}
