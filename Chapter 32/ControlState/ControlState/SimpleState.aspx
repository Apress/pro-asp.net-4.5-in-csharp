<%@ Page Language="C#" AutoEventWireup="true"
    EnableViewState="true" ViewStateEncryptionMode="Auto" EnableViewStateMac="true" 
    ViewStateMode="Disabled"
    CodeBehind="SimpleState.aspx.cs" Inherits="ControlState.SimpleState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin-bottom: 10px;} </style>
</head>
<body>
    <form id="form1" runat="server">
        <div><cc:SimpleTime runat="server" ViewStateMode="Enabled" /></div>
        <div>View state works: <%= ViewStateWorks %></div>
        <div>Control state works: <%= ControlStateWorks %></div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
