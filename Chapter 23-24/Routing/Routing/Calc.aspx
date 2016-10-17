<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Calc.aspx.cs" Inherits="Routing.Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        span {margin-right: 5px;}
        button[type=submit] { margin-top: 5px;}
        input { width: 40px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <input id="first" name="first" runat="server"/>
        <select id="operation" name="operation" runat="server">
            <option>plus</option><option>minus</option>
        </select>
        <input id="second" name="second" runat="server"/>
        <asp:PlaceHolder ID="resultPh" runat="server" Visible="false">
            = <span id="result" runat="server"></span>
        </asp:PlaceHolder>
        <div>
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
