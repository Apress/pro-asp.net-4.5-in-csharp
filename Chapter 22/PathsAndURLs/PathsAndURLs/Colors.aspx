<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Colors.aspx.cs" Inherits="PathsAndURLs.Colors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    The colors are:
    <ol>
        <asp:Repeater ID="Repeater1" ItemType="System.String" SelectMethod="GetColors" runat="server">
            <ItemTemplate>
                <li><%# Item %></li>                    
            </ItemTemplate>
        </asp:Repeater>
    </ol>
</body>
</html>
