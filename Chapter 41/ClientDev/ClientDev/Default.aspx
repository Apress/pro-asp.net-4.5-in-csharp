<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" Inherits="ClientDev.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
        <%: System.Web.Optimization.Styles.Render("~/bundle/basicCSS", 
        "~/Content/themes/base/jqueryUICSS") %>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/jquery", "~/bundle/jqueryui") %>
    <script>
        $(document).ready(function () {
            $('input[type=submit]').button();
        });
    </script>
</head>


<body>
    <form id="form1" runat="server">
        <div>
            <input type="submit" name="color" value="Red" />
            <input type="submit" name="color" value="Green" />
            <input type="submit" name="color" value="Blue" />
        </div>
        <div>
            <span class="message">
                Selected Color:
                <span id="selectedValue" runat="server">
                    <span class="error">No selection has been made</span>
                </span>
            </span>
        </div>
    </form>
</body>
</html>
