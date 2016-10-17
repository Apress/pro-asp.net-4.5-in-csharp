<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Store.Master"
AutoEventWireup="true" CodeBehind="Checkout.aspx.cs"   
    Inherits="SportsStore.Pages.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContent" runat="server">
<div id="content">

    <div id="checkoutForm" class="checkout" runat="server">
        <h2>Checkout Now</h2>    
        Please enter your details, and we'll ship your goods right away!

        <div id="errors"  data-valmsg-summary="true">
            <ul><li style="display:none"></li></ul>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server"/>
        </div>

        <h3>Ship to</h3>
        <div>
            <label for="name">Name:</label>
            <SX:VInput Property="Name" runat="server" />
        </div>

        <h3>Address</h3>
        <div>
            <label for="line1">Line 1:</label>
            <SX:VInput Property="Line1" runat="server" />
        </div>
        <div>
            <label for="line2">Line 2:</label>
            <SX:VInput Property="Line2" runat="server" />
        </div>
        <div>
            <label for="line3">Line 3:</label>
            <SX:VInput Property="Line3" runat="server" />
        </div>
        <div>
            <label for="city">City:</label>
            <SX:VInput Property="City" runat="server" />
        </div>
        <div>
            <label for="state">State:</label>
            <SX:VInput Property="State" runat="server" />
        </div>

        <h3>Options</h3>
        <input type="checkbox" id="giftwrap" name="giftwrap" value="true"/>
        Gift wrap these items?
        
        <p class="actionButtons">
            <button class="actionButtons" type="submit">Complete Order</button>
        </p>
    </div>
    <div id="checkoutMessage" runat="server">
        <h2>Thanks!</h2>
        Thanks for placing your order. We'll ship your goods as soon as possible.    
    </div>
</div>
</asp:Content>
