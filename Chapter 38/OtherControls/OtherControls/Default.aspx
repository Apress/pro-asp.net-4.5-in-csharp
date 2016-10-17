<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" Inherits="OtherControls.Default" %>

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
            <span id="result" runat="server">0</span> clicks
        </div>
        <div>
            <asp:LinkButton ID="lButton" runat="server" OnClick="HandleClick" 
                CommandName="Click" CommandArgument="Submit" Text="Click Me"
                Font-Underline="false" ForeColor="Red" BackColor="LightGray"
                BorderStyle="Solid"/>
        </div> 
    </form>
</body>
</html>
