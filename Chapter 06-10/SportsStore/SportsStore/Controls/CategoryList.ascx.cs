using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using SportsStore.Models.Repository;

namespace SportsStore.Controls {
    public partial class CategoryList : System.Web.UI.UserControl {

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected IEnumerable<string> GetCategories() {
            return new Repository().Products
                .Select(p => p.Category)
                .Distinct()
                .OrderBy(x => x);
        }

        protected string CreateHomeLinkHtml() {
            string path = RouteTable.Routes.GetVirtualPath(null, null).VirtualPath;
            return string.Format("<a href='{0}'>Home</a>", path);
        }

        protected string CreateLinkHtml(string category) {

            string selectedCategory = (string)Page.RouteData.Values["category"]
                ?? Request.QueryString["category"];

            string path = RouteTable.Routes.GetVirtualPath(null, null,
                new RouteValueDictionary() { { "category", category }, 
                    {"page", "1"} }).VirtualPath;

            return string.Format("<a href='{0}' {1}>{2}</a>",
                path, category == selectedCategory ? "class='selected'" : "", category);
        }
    }
}
