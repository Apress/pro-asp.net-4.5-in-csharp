using System;
using System.Collections.Generic;
using Controls.Custom;

namespace Controls {
    public partial class Loader : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

            BasicCalc calc = (BasicCalc)LoadControl("~/Custom/BasicCalc.ascx");
            calc.Initial = 500;

            List<Calculation> calcs = new List<Calculation> {
                new Calculation { Value = 90, Operation = BasicCalc.OperationType.Plus },
                new Calculation { Value = 50, Operation = BasicCalc.OperationType.Minus }
            };
            calc.Calculations = calcs;
            controlTarget.Controls.Add(calc);
        }
    }
}
