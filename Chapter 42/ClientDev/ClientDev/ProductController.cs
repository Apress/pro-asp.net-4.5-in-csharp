using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClientDev.Models;
using ClientDev.Models.Repository;

namespace ClientDev {

    public class ProductView {

        public ProductView() { }

        public ProductView(Product product) {
            this.ProductID = product.ProductID;
            this.Name = product.Name;
            this.Price = product.Price;
            this.Category = product.Category;
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Product ToProduct() {
            return new Product {
                ProductID = this.ProductID,
                Name = this.Name,
                Price = this.Price,
                Category = this.Category
            };
        }
    }

    public class ProductController : ApiController {

        public IEnumerable<ProductView> Get() {
            return new Repository().Products
                .Select(p => new ProductView(p));
        }

        public IEnumerable<ProductView> Get([System.Web.ModelBinding.Form] 
    string categoryFilter) {

            if (categoryFilter == null || categoryFilter == "All") {
                return Get();
            } else {
                return new Repository().Products
                    .Where(p => p.Category == categoryFilter)
                    .Select(p => new ProductView(p));
            }
        }


        public ProductView Get(int id) {
            return new Repository().Products
                .Where(p => p.ProductID == id)
                .Select(p => new ProductView(p)).FirstOrDefault();
        }

        public HttpResponseMessage Post([FromBody] Product value) {
            if (ModelState.IsValid) {
                new Repository().AddProduct(value);
                return Request.CreateResponse(HttpStatusCode.OK, new ProductView(value));
            } else {
                List<string> errors = new List<string>();
                foreach (var state in ModelState) {
                    foreach (var error in state.Value.Errors) {
                        errors.Add(error.ErrorMessage);
                    }
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
            }
        }

        public HttpResponseMessage Put(int id, [FromBody] ProductView value) {
            if (ModelState.IsValid) {
                Repository repo = new Repository();
                Product current = repo.Products
                    .Where(p => p.ProductID == id).FirstOrDefault();
                if (current != null) {
                    current.Name = value.Name;
                    current.Price = value.Price;
                    current.Category = value.Category;
                }
                return Request.CreateResponse(HttpStatusCode.OK);
            } else {
                List<string> errors = new List<string>();
                foreach (var state in ModelState) {
                    foreach (var error in state.Value.Errors) {
                        errors.Add(error.ErrorMessage);
                    }
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
            }
        }


        public void Delete(int id) {
            Repository repo = new Repository();
            Product product = repo.Products
                .Where(p => p.ProductID == id).FirstOrDefault();
            if (product != null) {
                repo.DeleteProduct(product);
            }
        }
    }
}
