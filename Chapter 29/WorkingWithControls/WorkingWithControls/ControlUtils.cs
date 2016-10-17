using System.Diagnostics;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkingWithControls {

    public class ControlUtils {
        public static void EnumerateControls(Control target, bool ignoreLiteral = false) {
            foreach (Control c in target.Controls.Cast<Control>()) {
                if (!(c is LiteralControl) || !ignoreLiteral) {
                    Debug.WriteLine(string
                        .Format("Control ID: {0}, Type: {1}, Parent: {2}",
                        c.ID, c.GetType().Name, target.ID));
                    if (c.Controls.Count > 0) {
                        EnumerateControls(c, ignoreLiteral);
                    }
                }
            }
        }

        public static void AddButtonClickHandlers(Control target) {
            foreach (Control c in target.Controls.Cast<Control>()) {
                if (c is Button) {
                    Button b = c as Button;
                    b.Text += " (+)";
                    b.Click += (src, args) => {
                        Debug.WriteLine("Button Clicked: " + b.Text);
                    };
                } else if (c.Controls.Count > 0) {
                    AddButtonClickHandlers(c);
                }
            }
        }

    }
}
