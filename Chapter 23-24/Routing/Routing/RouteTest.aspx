<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="RouteTest.aspx.cs" Inherits="Routing.RouteTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        div.routeTest th { text-align: left;}
        div.routeTest td { padding: 2px;}
        div.routeTest { border: solid thin black; margin-bottom: 10px; padding: 10px}
    </style>
</head>
<body>
    <div class="routeTest">
    <h3>Route Test</h3>
    <table>
        <thead>
            <tr><th>Match</th><th>Route</th><th>Values</th></tr>
        </thead>
        <tbody>
            <asp:Repeater ID="Repeater1" ItemType="Routing.RouteMatchInfo" 
                    SelectMethod="GetRouteMatches" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Item.matches %></td>
                        <td><%# Item.path %></td>
                        <td><%# Item.values %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    </div>
</body>
</html>
