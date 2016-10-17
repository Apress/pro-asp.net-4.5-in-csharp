<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FormOne.aspx.cs" Inherits="OtherControls.FormOne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin-bottom: 10px; }</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>Enter your name: <input id="nameValue" runat="server" /></div>
    <asp:Button Text="Submit" PostBackUrl="/FormTwo.aspx" runat="server"/>
    </form>
</body>
</html>
