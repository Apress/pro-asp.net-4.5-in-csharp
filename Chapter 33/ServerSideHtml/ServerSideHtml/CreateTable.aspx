<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="CreateTable.aspx.cs" Inherits="ServerSideHtml.CreateTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table { border: thin solid black; }
        td, th { padding: 2px 5px; }
        thead > tr { border: solid thin black;}
        td:last-child, th:last-child { text-align: right;}
        div { margin-bottom: 10px; }
    </style>
</head>
<body>
    <div id="container" runat="server">
        <table >
            <thead><tr><th>Color</th><th>Count</th></tr></thead>
            <tbody>
                <asp:Repeater SelectMethod="GetRows" ItemType="System.String[]" 
                       runat="server">
                    <ItemTemplate>
                        <tr><td><%# Item[0] %></td><td><%# Item[1] %></td></tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
            <tfoot>
                <tr><th>Total:</th><th>46</th></tr>
            </tfoot>
        </table>   
    </div>
</body>
</html>
