<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" 
    AutoEventWireup="true" CodeBehind="Orders.aspx.cs" 
    EnableViewState="false" Inherits="SportsStore.Pages.Admin.Orders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="outerContainer">
        <table id="ordersTable">
            <tr><th>Name</th><th>City</th><th>Items</th><th>Total</th><th></th></tr>
            <asp:Repeater runat="server" SelectMethod="GetOrders" 
                    ItemType="SportsStore.Models.Order">
                <ItemTemplate>
                        <tr>
                            <td><%#: Item.Name %></td>
                            <td><%#: Item.City %></td>
                            <td><%# Item.OrderLines.Sum(ol => ol.Quantity) %></td>
                            <td><%# Total(Item.OrderLines).ToString("C") %> </td>
                            <td>
                                <asp:PlaceHolder Visible="<%# !Item.Dispatched %>" runat="server">
                                    <button type="submit" name="dispatch" 
                                        value="<%# Item.OrderId %>">Dispatch</button>
                                </asp:PlaceHolder>
                            </td>
                        </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>

    <div id="ordersCheck">
        <asp:CheckBox ID="showDispatched" runat="server" Checked="false" AutoPostBack="true" />
        Show Dispatched Orders?
    </div>

</asp:Content>
