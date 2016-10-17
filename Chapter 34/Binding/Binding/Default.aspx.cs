using System;
using System.Web.ModelBinding;
using Binding.Models;

namespace Models {
    public partial class Default : System.Web.UI.Page {

        public Person GetData([Form] Person person) {
            return person;
        }
    }
}
