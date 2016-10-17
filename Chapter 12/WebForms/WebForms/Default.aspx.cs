using System;

namespace WebForms {
    public partial class Default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
        }

        protected string GetCity() {
            string[] cities = { "London", "New York", "Paris" };
            return cities[new Random().Next(cities.Length)];
        }
    }
}
