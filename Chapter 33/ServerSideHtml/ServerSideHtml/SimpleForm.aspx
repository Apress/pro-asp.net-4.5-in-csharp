<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="SimpleForm.aspx.cs" Inherits="ServerSideHtml.SimpleForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin: 10px;} </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>Name: <input id="name" value="Bob" runat="server" /></div>
        <div>Password: 
            <input id="pass" type="password" value="secret" runat="server"/>
        </div>
        <div>
            <input id="hiddenValue" type="hidden" value="true" runat="server"/>
            <input id="button" type="submit" value="Submit" />
        </div>
    </form>
</body>
</html>
