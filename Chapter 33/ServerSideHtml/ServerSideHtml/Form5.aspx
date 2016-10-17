<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Form5.aspx.cs" Inherits="ServerSideHtml.Form5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> input[type=range] { margin-left: 10px; width: 200px;}</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Number 1:
            <input id="userVal" type="range" step="5" min="50" max="100" runat="server"/>
        </div>
        <div id="inputContainer" runat="server">Number 2:</div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
