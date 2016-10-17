<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FormView.aspx.cs" Inherits="Data.FormView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles.css" />
</head>
<body>
<form id="form1" runat="server">
    <asp:FormView ID="formView" runat="server" CssClass="formViewTable"
            ItemType="Data.Models.Product" SelectMethod="GetProducts" 
            UpdateMethod="UpdateProduct" DeleteMethod="DeleteProduct" 
            InsertMethod="InsertProduct" DataKeyNames="ProductID"
            AllowPaging="true">
        <ItemTemplate>
            <table class="formViewTable innerTable">
                <tr><th>ID:</th><td><%#: Item.ProductID %></td></tr>        
                <tr><th>Name:</th><td><%#: Item.Name %></td></tr>        
                <tr><th>Category:</th><td><%#: Item.Category %></td></tr>        
                <tr><th>Price:</th><td><%#: Item.Price%></td></tr>        
            </table>
        </ItemTemplate>
        <PagerTemplate>
            <asp:Button CommandName="Page" CommandArgument="First" Text="First" 
                runat="server" />
            <asp:Button CommandName="Page" CommandArgument="Prev" Text="Prev" 
                runat="server" />
            <%= formView.PageIndex %> of <%= formView.PageCount %>
            <asp:Button CommandName="Page" CommandArgument="Next" Text="Next" 
                 runat="server" />
            <asp:Button CommandName="Page" CommandArgument="Last" Text="Last" 
                 runat="server" />
        </PagerTemplate>
        <HeaderTemplate>
            <asp:Button CommandName="New" Text="New" runat="server" />
            <asp:Button CommandName="Delete" Text="Delete" runat="server" />
            <asp:Button CommandName="Edit" Text="Edit" runat="server" />
        </HeaderTemplate>
        <EditItemTemplate>
            <table class="formViewTable innerTable">
                <tr><th>Name:</th>
                    <td><input id="name" value="<%# BindItem.Name %>" 
                        runat="server" /></td></tr>        
                <tr><th>Category:</th>
                    <td><input id="category" value="<%# BindItem.Category %>" 
                        runat="server"/></td></tr>        
                <tr><th>Price:</th>
                    <td><input id="price" value="<%# BindItem.Price %>" 
                        runat="server"/></td></tr>        
                <tr><td colspan="2">
                    <asp:Button CommandName="Update" Text="Update" runat="server"
                        Visible="<%# formView.CurrentMode == FormViewMode.Edit %>" />
                    <asp:Button CommandName="Insert" Text="Insert" runat="server" 
                        Visible="<%# formView.CurrentMode == FormViewMode.Insert %>"/>
                        <asp:Button CommandName="Cancel" Text="Cancel" runat="server" />
                    </td>
                </tr>
            </table>
        </EditItemTemplate>
    </asp:FormView>
</form>
</body>
</html>
