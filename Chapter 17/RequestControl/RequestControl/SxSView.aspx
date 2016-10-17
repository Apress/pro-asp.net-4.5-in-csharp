<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="SxSView.aspx.cs" Inherits="RequestControl.SxSView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        div.contentPanel {
            width: 45%; border: thin solid black;
            margin: 10px; padding: 10px;
            float: left; overflow: auto; }
    </style>
</head>
<body>
    <div>
        <div id="htmlPanel" class="contentPanel" runat="server"></div>
        <div id="srcPanel" class="contentPanel" runat="server"></div>
    </div>
</body>
</html>
