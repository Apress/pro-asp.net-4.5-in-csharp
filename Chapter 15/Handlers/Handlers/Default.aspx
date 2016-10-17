<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" Inherits="Handlers.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        The time is <%: DateTime.Now.ToShortTimeString() %>
    </div>
    </form>
</body>
</html>