<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlOverride.aspx.cs" Inherits="Caching.ControlOverride" %>

<%@ Register TagPrefix="CC" TagName="Outer" Src="~/OuterControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        div.panel { margin: 5px; padding: 5px; border: thin solid black;}
    </style>
</head>
<body>
    <form id="Form1" runat="server">
        <CC:Outer runat="server" />
        <div class="panel"><button type="submit">Submit</button></div>
    </form>
</body>
</html>
