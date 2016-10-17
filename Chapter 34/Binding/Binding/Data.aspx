<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Data.aspx.cs" Inherits="Binding.Data" %>

<%@ Register TagPrefix="CC" Assembly="Binding" Namespace="Binding.Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="max" value="5" runat="server" />
            <CC:OperationSelector id="opSelector" runat="server" />
            <button type="submit">Generate</button>
        </div>
        <div>
            <asp:Repeater SelectMethod="GetData" ItemType="System.String" 
                    runat="server" ViewStateMode="Disabled">
                <ItemTemplate>
                    <p><%# Item %></p>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>