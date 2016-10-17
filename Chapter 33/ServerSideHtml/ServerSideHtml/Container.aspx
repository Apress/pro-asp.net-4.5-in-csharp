<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Container.aspx.cs" Inherits="ServerSideHtml.Container" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> span {display: inline-block;} </style>
</head>
<body>
    <div id="outerDiv" runat="server">
        This is some text
        <span id="spanElem" runat="server">
            This is a span element <%= DateTime.Now %>
        </span>
        <div id="innerDiv" runat="server">
            This is the inner div element
        </div>
    </div>
</body>
</html>
