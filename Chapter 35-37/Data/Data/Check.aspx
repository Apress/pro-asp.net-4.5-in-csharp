<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Check.aspx.cs" Inherits="Data.Check" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin-bottom: 10px; } </style>
    <script src="Scripts/jquery-1.8.2.js"></script>
    <script>
        var IDs = {
            controlSelector: "#<%= cbl.ClientID %> input",
            allInputID: "<%= cbl.ClientID %>_0",
            allInputSelector: "#<%= cbl.ClientID %>_0"
        }
        $(document).ready(function () {
            $(IDs.controlSelector).change(function (e) {
                var selection = (e.target.id == IDs.allInputID) ?
                    $(IDs.controlSelector).not(IDs.allInputSelector)
                         .attr("checked", false) :
                    $(IDs.allInputSelector).attr("checked", false);
                selection.attr("checked", false);
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="cbl" AppendDataBoundItems="true" RepeatColumns="3"
                    SelectMethod="GetProducts" runat="server">
                <asp:ListItem Text="All" Selected="True" />
            </asp:CheckBoxList>
        </div>
        <div>
            Selection: <span id="selection" runat="server"></span>
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
