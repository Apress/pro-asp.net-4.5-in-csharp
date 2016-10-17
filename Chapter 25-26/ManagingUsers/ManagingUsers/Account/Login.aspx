<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Login.aspx.cs" Inherits="ManagingUsers.Account.Login" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        div.details { margin-bottom: 20px; }
        div { margin-top: 5px; }
        label { width: 90px; display: inline-block; }
        button {margin: 10px 10px 0 0;}
        span.error { color: red; border: solid double red; visibility: collapse;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <span id="message" class="error" runat="server">
            Incorrect username or password. Please try again.
        </span>
        <div><label>User:</label><input name="user"/></div>
        <div><label>Password:</label><input type="password" name="pass"/></div>
        <div>
            <button name="action" value="login" type="submit">Log In</button>
            <a href="Register.aspx">Create an Account</a>
        </div>
    </form>
</body>
</html>
