<%@ Control Language="C#" AutoEventWireup="true" ViewStateMode="Disabled"
    CodeBehind="TripleButtonControl.ascx.cs" 
    Inherits="WorkingWithControls.TripleButtonControl" %>

<div>
    <asp:Repeater ItemType="WorkingWithControls.ButtonCountResult" 
            SelectMethod="GetClickCounts" runat="server">
        <ItemTemplate>
            <div>Button <%# Item.Index %> presses: <%# Item.Count %></div>
        </ItemTemplate>
    </asp:Repeater>
</div>
<div>
    <asp:Repeater ItemType="WorkingWithControls.ButtonCountResult"
        SelectMethod="GetClickCounts" runat="server">
        <ItemTemplate>
            <button name="button" value="<%# Item.Index %>" 
                type="submit">Button <%# Item.Index %></button>
        </ItemTemplate>
    </asp:Repeater>
</div>
