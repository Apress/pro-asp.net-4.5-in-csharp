<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Recover.aspx.cs" Inherits="ManagingUsers.Account.Recover" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        div.details { margin-bottom: 20px; }
        label { display: inline-block; margin-right: 5px;}
        span.error { color: red; margin-bottom:10px; display: block;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Password Recovery</h3>
        <asp:PlaceHolder ID="error" Visible="false" runat="server">
            <span id="message" class="error" runat="server"></span>
        </asp:PlaceHolder>

        <asp:PlaceHolder ID="username" runat="server" Visible="true">
            <div class="details">
                <label>Enter Username:</label>
                <input id="user" name="user" runat="server"/>
            </div>            
            
        </asp:PlaceHolder>

        <asp:PlaceHolder ID="question" Visible="false" runat="server">
            <div class="details">
                <label id="questionLabel" runat="server"></label>
                <input name="answer"/>
            </div>            
        </asp:PlaceHolder>

        <asp:PlaceHolder ID="newpass" Visible="false" runat="server">
            <div class="details">Your new password is: <b>
                <span id="password" runat="server"></span></b></div>            
        </asp:PlaceHolder>
        <div>
            <input type="submit" id="task" name="task" value="Next" runat="server"/>
        </div>
    </form>
</body>
</html>
