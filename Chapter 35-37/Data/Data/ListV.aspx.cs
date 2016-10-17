using System.Linq;
using Data.Models;
using Data.Models.Repository;

namespace Data {
    public partial class ListV : System.Web.UI.Page {

        public IQueryable<Product> GetProducts() {
            return new Repository().Products.AsQueryable<Product>();
        }

        public void UpdateProduct(int? productID) {
            Repository repo = new Repository();
            Product product = repo.Products
                .Where(p => p.ProductID == productID).FirstOrDefault();
            if (product != null && TryUpdateModel<Product>(product)) {
                repo.SaveProduct(product);
            }
        }
    }
}
