<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Radio.aspx.cs" Inherits="Data.Radio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin-bottom: 10px; } </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList ID="radio" runat="server" 
                    RepeatDirection="Horizontal" RepeatColumns="3"
                    AppendDataBoundItems="true" SelectMethod="GetProducts">
                <asp:ListItem Selected="True" Text="All" />
            </asp:RadioButtonList>
        </div>
        <div>
            Selection: <span id="selection" runat="server"></span>
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
