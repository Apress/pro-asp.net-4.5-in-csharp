<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="MultiViewDemo.aspx.cs" Inherits="OtherControls.MultiViewDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin-bottom: 10px; } </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:MultiView ID="mView" runat="server">
            <asp:View ID="firstView" runat="server">
                <div>This is the first view</div>
            </asp:View>
            <asp:View ID="secondView" runat="server">
                <div>This is the second view</div>
            </asp:View>
            <asp:View ID="thirdView" runat="server">
                <div>This is the third view</div>
            </asp:View>
        </asp:MultiView>
        <div>
            Select view:
            <select id="nameSelect" runat="server">
                <option value="0" selected="selected">First View</option>
                <option value="1">Second View</option>
                <option value="2">Third View</option>
            </select>
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
