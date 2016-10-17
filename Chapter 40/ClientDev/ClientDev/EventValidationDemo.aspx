<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="true"
    CodeBehind="EventValidationDemo.aspx.cs" Inherits="ClientDev.EventValidationDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin-bottom: 10px; } </style>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/jquery") %>
    <script>
        $(document).ready(function () {
            var targetElem = $("#nameSelect");
            targetElem.attr("disabled", "true");
            $.ajax({
                url: "/api/product",
                type: "GET",
                success: function (data) {
                    for (var i = 0; i < data.length; i++) {
                        $("<option>" + data[i].Name
                            + "</option>").appendTo("#nameSelect");
                    }
                    targetElem.removeAttr("disabled");
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <select id="nameSelect" runat="server"> 
                <option>All</option>
            </select>
            <button type="submit">Submit</button>
        </div>
        <div>Form value: <span id="formValue" runat="server"></span></div>
    </form>
</body>
</html>
