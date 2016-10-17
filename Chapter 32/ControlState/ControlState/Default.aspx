<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ControlState.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin-bottom: 10px;} </style>
</head>
<body>
  <form id="form1" runat="server">
     <CC:Counter LeftValue="10" RightValue="10" runat="server" EnableViewState="false" />
  </form>
</body>
</html>
