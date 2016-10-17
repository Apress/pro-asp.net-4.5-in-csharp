<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="SharedControl.aspx.cs" Inherits="Caching.SharedControl" %>

<%@ Register TagPrefix="CC" TagName="Time" Src="~/CurrentTime.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <div><CC:Time id="timeControl" runat="server" /></div>
</body>
</html>
