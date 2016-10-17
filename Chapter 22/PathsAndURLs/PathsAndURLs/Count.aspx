<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Count.aspx.cs" Inherits="PathsAndURLs.Count" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    The numbers are:
    <ul>
        <asp:Repeater ID="Repeater1" ItemType="System.Int32" SelectMethod="GetNumbers" runat="server">
            <ItemTemplate>
                <li><%# Item %></li>                    
            </ItemTemplate>
        </asp:Repeater>
    </ul>    
</body>
</html>
