<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="CreateProduct.aspx.cs" Inherits="ClientDev.CreateProduct" %>

<%@ Register TagPrefix="CC" Assembly="ClientDev" Namespace="ClientDev" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        th { text-align: left; }
        td[colspan="2"] { text-align: center; padding: 10px 0; }
        .error { color: red; }
        .input-validation-error { border: medium solid red;}
    </style>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/validation") %>
    <script src="Scripts/CreateProduct.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="errorSummary" data-valmsg-summary="true" class="error">
            <ul><li style="display:none"></li></ul>
            <asp:ValidationSummary runat="server" CssClass="error" />
        </div>
        <table>
            <CC:ValidationRepeater runat="server" 
                ItemType="ClientDev.ValidationRepeaterDataItem"
                ModelType ="ClientDev.Models.Product"
                Properties="Name, Category, Price" >
                <PropertyTemplate>
                    <tr>
                        <td><%# Item.PropertyName %></td>
                        <td>
                            <input id="<%# Item.PropertyName %>"  
                                name="<%# Item.PropertyName %>"  
                                <%# Item.ValidationAttributes %> />
                        </td>
                    </tr>
                </PropertyTemplate>
            </CC:ValidationRepeater>
            <tr>
                <td colspan="2"><input type="submit" value="Create" runat="server"/></td>
            </tr>
            <tr><th>ID</th><th>Name</th><th>Category</th><th>Price</th></tr>
            <asp:Repeater runat="server" 
                    ItemType="ClientDev.Models.Product" SelectMethod="GetCreated">
                <ItemTemplate>
                    <tr>
                        <td><%#: Item.ProductID %></td>
                        <td><%#: Item.Name %></td>
                        <td><%#: Item.Category %></td>
                        <td><%#: Item.Price.ToString("F2") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </form>
</body>
</html>
