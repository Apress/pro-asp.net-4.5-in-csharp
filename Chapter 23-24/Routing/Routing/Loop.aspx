<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Loop.aspx.cs" Inherits="Routing.Loop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <p>This is the Loop.aspx Web Form</p>
    <ul>
        <asp:Repeater ID="Repeater1" ItemType="System.Int32" 
                SelectMethod="GetValues" runat="server">
            <ItemTemplate>
                <li><%# Item %></li>
            </ItemTemplate>
        </asp:Repeater> 
    </ul>
</body>
</html>
