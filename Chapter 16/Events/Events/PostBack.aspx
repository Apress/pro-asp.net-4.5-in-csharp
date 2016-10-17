<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="PostBack.aspx.cs" Inherits="Events.PostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:PlaceHolder id="firstPH" runat="server">
            <div>
                <input id="firstNumber" runat="server" />
                +
                <input id="secondNumber" runat="server"/>
            </div>
            <button type="submit">Calculate</button>
        </asp:PlaceHolder>

        <asp:PlaceHolder id="secondPH" runat="server">
            <p>The total is <span id="result" runat="server"></span></p>
        </asp:PlaceHolder>
    </div>
    </form>
</body>
</html>
