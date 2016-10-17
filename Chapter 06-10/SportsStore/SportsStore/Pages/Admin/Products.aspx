<%@ Page Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" 
    AutoEventWireup="true" CodeBehind="Products.aspx.cs" 
    Inherits="SportsStore.Pages.Admin.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ListView ItemType="SportsStore.Models.Product"  SelectMethod="GetProducts" 
        DataKeyNames="ProductID" UpdateMethod="UpdateProduct" DeleteMethod="DeleteProduct"
        InsertMethod="InsertProduct" InsertItemPosition="LastItem" EnableViewState="false"
        runat="server">
        <LayoutTemplate>
            <div class="outerContainer">
                <table id="productsTable">
                    <tr>
                        <th>Name</th>
                        <th>Description</th>
                        <th>Category</th>
                        <th>Price</th>
                    </tr>
                    <tr runat="server" id="itemPlaceholder"></tr>
                </table>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Item.Name %></td>
                <td class="description"><span><%# Item.Description %></span></td>
                <td><%# Item.Category %></td>
                <td><%# Item.Price.ToString("c") %></td>
                <td>
                    <asp:Button CommandName="Edit" Text="Edit" runat="server" />
                    <asp:Button CommandName="Delete" Text="Delete" runat="server" />
                </td>
            </tr>
        </ItemTemplate>
        <EditItemTemplate>
            <tr>
                <td><input name="name" value="<%# Item.Name %>" />
                    <input type="hidden" name="ProductID" value="<%# Item.ProductID %>" />
                </td>
                <td><input name="description" value="<%# Item.Description %>" /></td>
                <td><input name="category" value="<%# Item.Category %>" /></td>
                <td><input name="price" value="<%# Item.Price %>" /></td>
                <td>
                    <asp:Button CommandName="Update" Text="Update" runat="server"/>
                    <asp:Button CommandName="Cancel" Text="Cancel" runat="server"/>
                </td>
            </tr>   
        </EditItemTemplate>
        <InsertItemTemplate>
            <tr>
                <td><input name="name" />
                    <input type="hidden" name="ProductID" value="0" />
                </td>
                <td><input name="description" /></td>
                <td><input name="category"/></td>
                <td><input name="price" /></td>
                <td>
                    <asp:Button CommandName="Insert" Text="Add" runat="server"/>
                </td>       
            </tr>
        </InsertItemTemplate>
    </asp:ListView>
</asp:Content>
