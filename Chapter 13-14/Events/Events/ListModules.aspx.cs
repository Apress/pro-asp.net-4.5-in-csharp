using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Events {

    public class ModuleDescription {
        public string Name { get; set; }
        public string TypeName { get; set; }
    }

    public partial class ListModules : System.Web.UI.Page {

        public IEnumerable<ModuleDescription> GetModules() {
            HttpModuleCollection modules = Context.ApplicationInstance.Modules;
            foreach (string key in modules.AllKeys.OrderBy(x => x)) {
                yield return new ModuleDescription {
                    Name = key,
                    TypeName = modules[key].GetType().ToString()
                };
            }
        }
    }
}
