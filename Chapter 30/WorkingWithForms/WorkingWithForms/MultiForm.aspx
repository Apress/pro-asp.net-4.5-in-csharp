<%@ Page Language="C#" AutoEventWireup="true" ViewStateMode="Disabled"
    CodeBehind="MultiForm.aspx.cs" Inherits="WorkingWithForms.MultiForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div { margin-bottom: 10px;}
        label { width: 100px; display:inline-block}
        input[type=submit] {width: 120px;}
    </style>
</head>
<body>
    <div>
        <form method="post" action="MultiForm.aspx">
            <label>Enter a color:</label>
            <input id="color" value="Green" runat="server" />
            <button name="button" value="color">Submit Color</button>
        </form>
    </div>
    <div>
        <form method="post" action="MultiForm.aspx">
            <label>Enter a city:</label>
            <input id="city" value="London" runat="server" />
            <button name="button" value="city">Submit City</button>
        </form>
    </div>
    <div id="result" runat="server"></div>
</body>
</html>
