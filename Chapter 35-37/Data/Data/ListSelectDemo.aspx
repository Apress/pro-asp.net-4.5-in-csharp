<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="ListSelectDemo.aspx.cs" Inherits="Data.ListSelectDemo" %>

<%@ Register TagPrefix="CC" Assembly="Data" Namespace="Data.Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr><th>Name</th><th>Category</th><th>Price</th></tr>
                <asp:Repeater id="rep" ItemType="Data.Models.Product" 
                        SelectMethod="GetProducts" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#: Item.Name %></td>
                            <td><%#: Item.Category %></td>
                            <td><%#: Item.Price.ToString("F2") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
        <div>
            <CC:ListSelect id="ls" ItemType="System.Web.UI.WebControls.ListItem" 
                SelectMethod="GetCategories" runat="server" />
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
