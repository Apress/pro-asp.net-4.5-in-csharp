<%@ Control Language="C#" AutoEventWireup="true" 
    CodeBehind="BasicCalc.ascx.cs" Inherits="Controls.Custom.BasicCalc" %>

This is the BasicCalc control

<div>
    <input name="<%=GetId("initialVal") %>" value="<%= Initial %>"  /> 
    <asp:Repeater ID="calcRepeater" runat="server" EnableViewState="false"
            ItemType="Controls.Custom.Calculation" SelectMethod="GetCalculations">
        <ItemTemplate>
            <%# Item.Operation == OperationType.Plus ? "+" : "-" %>
            <input name="<%=GetId("calcValue") %>" value="<%# Item.Value %>"  /> 
            <input type="hidden" name="<%= GetId("calcOp") %>" 
                value="<%# Item.Operation %>" />
        </ItemTemplate>
    </asp:Repeater>
    <button type="submit">=</button>
    <span id="result" runat="server"></span>
</div>
