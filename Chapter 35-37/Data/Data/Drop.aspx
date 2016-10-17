<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Drop.aspx.cs" Inherits="Data.Drop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="drop" runat="server" 
                    SelectMethod="GetProducts" AppendDataBoundItems="true">
                <asp:ListItem Selected="True" Text="All"/>
            </asp:DropDownList>
        </div>
        <div>
            Selection: <span id="selection" runat="server"></span>
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
