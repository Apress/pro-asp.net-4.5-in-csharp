<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="GetTest.aspx.cs" Inherits="Routing.GetTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form action="/methodtest" method="post">
        <p>This is the GetTest.aspx Web For</p>
        <p>City: <input name="city" /></p>
        <p><button type="submit">Make a Post Request</button></p>
    </form>
</body>
</html>
