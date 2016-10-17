using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebForms {

    public class CommonPageBase : Page {

        protected string GetDayOfWeek() {
            return DateTime.Now.DayOfWeek.ToString();
        }
    }
}