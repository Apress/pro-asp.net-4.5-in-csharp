<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Commands.aspx.cs" Inherits="OtherControls.Commands" %>

<%@ Register TagPrefix="CC" Assembly="OtherControls" Namespace="OtherControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin-bottom: 10px;} </style>
</head>
<body>
    <form id="form1" runat="server">
        <CC:Counter id="counter" runat="server">
            <UITemplate>
                <div>
                    <asp:Button CommandName="Up" Text="Up" runat="server" />
                    <asp:Button CommandName="Down" Text="Down" runat="server" />
                </div>
                <div>
                    <asp:LinkButton CommandName="Up" Text="Increment" runat="server" />
                    <asp:LinkButton CommandName="Down" Text="Decrement" runat="server" />
                </div>
            </UITemplate>
        </CC:Counter>
    </form>
</body>
</html>
