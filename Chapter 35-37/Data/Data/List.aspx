<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="List.aspx.cs" Inherits="Data.List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="list" runat="server" AppendDataBoundItems="true" 
                SelectMethod="GetProducts" SelectionMode="Multiple">
                <asp:ListItem Selected="True" Text="All" />
            </asp:ListBox>
        </div>
        <div>
            Selection: <span id="selection" runat="server"></span>
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
