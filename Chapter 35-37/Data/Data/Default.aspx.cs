using System.Collections.Generic;
using System.Linq;
using System.Web.ModelBinding;
using Data.Models;
using Data.Models.Repository;

namespace Data {

    public class CategoryView {
        public string Name { get; set; }
        public string Selected { get; set; }
    }

    public partial class Default : System.Web.UI.Page {

        public IEnumerable<Product> GetProductData([Control("dSelect", "Value")] string filterSelect) {
            var productData = new Repository().Products;
            return (filterSelect ?? "All") == "All" ? productData
                : productData.Where(p => p.Category == filterSelect);
        }

        public IEnumerable<Product> GetCategories() {
            return new Product[] { new Product { Category = "All" } }
                .Concat((new Repository().Products
                .GroupBy(p => p.Category).Select(g => g.First())
                .OrderBy(c => c.Category)));
        }
    }
}
