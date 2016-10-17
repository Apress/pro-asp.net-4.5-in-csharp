<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="BaseClass.aspx.cs" Inherits="ServerSideHtml.BaseClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        input.user { border: medium solid black;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter your name: <input id="userInput" runat="server" />
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
