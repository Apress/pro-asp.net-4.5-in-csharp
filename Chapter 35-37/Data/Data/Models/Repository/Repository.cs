using System.Collections.Generic;
using System.Linq;

namespace Data.Models.Repository {

    public class Repository {
        private static Dictionary<int, Product> data = new Dictionary<int, Product>();

        public IEnumerable<Product> Products {
            get {
                return data.Values;
            }
        }

        public void SaveProduct(Product product) {
            data[product.ProductID] = product;
        }

        public void DeleteProduct(Product product) {
            if (data.ContainsKey(product.ProductID)) {
                data.Remove(product.ProductID);
            }
        }

        public void AddProduct(Product product) {
            product.ProductID = Products.Select(p => p.ProductID).Max() + 1;
            SaveProduct(product);
        }

        static Repository() {
            Product[] dataArray = new Product[] {
                new Product { Name = "Kayak", Category = "Watersports", Price = 275M},
                new Product { Name = "Lifejacket", Category = "Watersports", 
                    Price = 48.95M},
                new Product { Name = "Soccer Ball", Category = "Soccer", Price = 19.50M},
                new Product { Name = "Corner Flags", Category = "Soccer", 
                    Price = 34.95M},
                new Product { Name = "Stadium", Category = "Soccer", Price = 79500M},
                new Product { Name = "Thinking Cap", Category = "Chess", Price = 16M},
                new Product { Name = "Unsteady Chair", Category = "Chess", 
                    Price = 29.95M},
                new Product { Name = "Human Chess Board", Category = "Chess", 
                    Price = 75M},
                new Product { Name = "Bling-Bling King", Category = "Chess", 
                   Price = 1200M},
            };

            for (int i = 0; i < dataArray.Length; i++) {
                dataArray[i].ProductID = i;
                data[i] = dataArray[i];
            }
        }
    }
}