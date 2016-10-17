<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultipleErrors.aspx.cs" Inherits="ErrorHandling.MultipleErrors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <h1>Sorry</h1>
    <p>Something has gone wrong. We found the following problems:</p>
    <p><ul>
        <asp:Repeater ID="Repeater1" ItemType="System.String" SelectMethod="GetErrorMessages" 
            runat="server">
            <ItemTemplate>
                <li><%# Item %></li>        
            </ItemTemplate>
        </asp:Repeater>
    </ul></p>
    <p><a href="Default.aspx">Please try again.</a></p>    
</body>
</html>
