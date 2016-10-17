<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CartSummary.ascx.cs" 
    Inherits="SportsStore.Controls.CartSummary" %>

<div id="cartSummary">
    <span class="caption">
        <b>Your cart:</b>
        <span id="csQuantity" runat="server"></span> item(s),
        <span id="csTotal" runat="server"></span>
    </span>
    <a id="csLink" runat="server">Checkout</a>
</div>
