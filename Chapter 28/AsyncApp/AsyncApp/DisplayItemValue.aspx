<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="DisplayItemValue.aspx.cs" Inherits="AsyncApp.DisplayItemValue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    The length of the result is: <%: Context.Items["length"] %>
</body>
</html>
