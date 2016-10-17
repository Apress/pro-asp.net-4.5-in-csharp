using System;
using System.Web;

[assembly: PreApplicationStartMethod(
    typeof(CommonModules.ModuleRegistration), "RegisterModules")]

namespace CommonModules {

    public class ModuleRegistration {

        public static void RegisterModules() {
            Type[] moduleTypes = {
                typeof(CommonModules.TimerModule),
                typeof(CommonModules.LogModule)
            };

            foreach (Type t in moduleTypes) {
                HttpApplication.RegisterModule(t);
            }
        }
    }
}
