<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="RepeaterButtons.aspx.cs" 
    Inherits="WorkingWithControls.RepeaterButtons" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        #buttonTarget > input {margin: 10px 5px 0 0;}
        #selectedValue { margin-top: 10px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="buttonTarget" runat="server">
            <asp:Repeater ID="Repeater1" ItemType="System.String" SelectMethod="GetButtonDetails" 
                    OnItemCommand="HandleClick" runat="server">
                <ItemTemplate>
                    <asp:Button ID="Button1" Text="<%# Item %>" runat="server"/>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div id="selectedValue" runat="server"></div>
    </form>
</body>
</html>
