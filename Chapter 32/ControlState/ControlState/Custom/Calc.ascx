<%@ Control Language="C#" AutoEventWireup="true" 
    EnableViewState="true" ViewStateMode="Enabled"
    CodeBehind="Calc.ascx.cs" Inherits="ControlState.Custom.Calc" %>

<div>
    <input id="firstValue" runat="server" value="10"/> + 
    <input id="secondValue" runat="server" value ="31"/>
    <button type="submit"> = </button>
    <span id="resultValue" runat="server" />
</div>

<div>
    <h3>History:</h3>
    <ul>
    <asp:Repeater ItemType="System.String" 
            SelectMethod="GetHistory" runat="server" ViewStateMode="Disabled">
        <ItemTemplate>
            <li><%# Item %></li>        
        </ItemTemplate>
    </asp:Repeater>
    </ul>
</div>
