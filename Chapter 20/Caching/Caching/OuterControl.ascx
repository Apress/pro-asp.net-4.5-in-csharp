<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OuterControl.ascx.cs" 
    Inherits="Caching.OuterControl" %>

<%@ OutputCache Duration="60" VaryByParam="none" VaryByControl="ddl" %>

<div class="panel">
    Response generated at: <%: DateTime.Now.ToLongTimeString() %>
</div>
<div class="panel">
    <asp:DropDownList ID="ddl" runat="server">
        <asp:ListItem>Red</asp:ListItem>
        <asp:ListItem>Green</asp:ListItem>
        <asp:ListItem>Blue</asp:ListItem>
    </asp:DropDownList>
</div>
