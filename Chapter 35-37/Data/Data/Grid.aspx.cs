using System.Linq;
using Data.Models;
using Data.Models.Repository;

namespace Data {
    public partial class Grid : System.Web.UI.Page {

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

        public void DeleteProduct(int? productID) {
            Repository repo = new Repository();
            Product product = repo.Products
                .Where(p => p.ProductID == productID).FirstOrDefault();
            if (product != null) {
                repo.DeleteProduct(product);
            }
        }

        public void InsertProduct() {
            Product product = new Product();
            if (TryUpdateModel<Product>(product)) {
                new Repository().AddProduct(product);
            }
        }
    }
}