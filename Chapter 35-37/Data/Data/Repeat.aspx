<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Repeat.aspx.cs" Inherits="Data.Repeat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles.css" />
</head>
<body>
    <asp:Repeater id="rep" ItemType="Data.Models.Product" 
            SelectMethod="GetProducts" runat="server">
        <HeaderTemplate>
            <table>
                <tr><th>Name</th><th>Category</th><th>Price</th></tr>
        </HeaderTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>    
</body>
</html>
