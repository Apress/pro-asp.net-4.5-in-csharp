<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Bullet.aspx.cs" Inherits="Data.Bullet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:BulletedList ID="bullet" ItemType="System.String" SelectMethod="GetProducts"
            AppendDataBoundItems="true" BulletStyle="Square" runat="server">
            <asp:ListItem Selected="True" Text="All" />
        </asp:BulletedList>
    </form>
</body>
</html>
