using System.Collections.Generic;
using System.Linq;
using Data.Models.Repository;

namespace Data {
    public partial class Bullet : System.Web.UI.Page {

        public IEnumerable<string> GetProducts() {
            return new Repository().Products.Select(p => p.Name);
        }
    }
}