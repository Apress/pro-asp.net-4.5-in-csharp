<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="ValidControls.aspx.cs" Inherits="WorkingWithForms.ValidControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div { margin-bottom: 10px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Enter your name: 
        <asp:TextBox ID="name" runat="server" ValidateRequestMode="Disabled" />
    </div>
    <div>You entered: <%= name.Text %></div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
