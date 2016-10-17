using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportsStore.Models;
using SportsStore.Models.Repository;
using System.Web.ModelBinding;

namespace SportsStore.Pages.Admin {
    public partial class Products : System.Web.UI.Page {
        private Repository repo = new Repository();

        protected void Page_Load(object sender, EventArgs e) {

        }

        public IEnumerable<Product> GetProducts() {
            return repo.Products;
        }

        public void UpdateProduct(int productID) {
            Product myProduct = repo.Products
                .Where(p => p.ProductID == productID).FirstOrDefault();
            if (myProduct != null && TryUpdateModel(myProduct, 
                new FormValueProvider(ModelBindingExecutionContext))) {
                    repo.SaveProduct(myProduct);
            }
        }

        public void DeleteProduct(int productID) {
            Product myProduct = repo.Products
                .Where(p => p.ProductID == productID).FirstOrDefault();
            if (myProduct != null) {
                repo.DeleteProduct(myProduct);
            }
        }

        public void InsertProduct() {
            Product myProduct = new Product();
            if (TryUpdateModel(myProduct, 
                new FormValueProvider(ModelBindingExecutionContext))) {
                repo.SaveProduct(myProduct);
            }
        }
    }
}