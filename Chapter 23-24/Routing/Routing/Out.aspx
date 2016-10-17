<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Out.aspx.cs" Inherits="Routing.Out" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><p>This is the Out.aspx Web Form</p></div>
        <a href="<%: GenerateURL() %>">Link to Loop.aspx Web Form</a>
    </form>
</body>
</html>
