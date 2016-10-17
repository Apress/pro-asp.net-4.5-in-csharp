<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FileInfo.aspx.cs" Inherits="PathsAndURLs.FileInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <p>Content from file:</p>
    <%= GetFileContent() %>
</body>
</html>
