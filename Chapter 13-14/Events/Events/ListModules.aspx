<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListModules.aspx.cs" 
    Inherits="Events.ListModules" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        th, td { border-bottom: thin solid black; text-align: left;
            padding: 3px;}
        td span { display: inline-block; text-overflow: ellipsis;
            overflow: hidden; white-space:nowrap; width: 300px;}
        table { border-collapse: collapse;}
    </style>
</head>
<body>
    <div>
        <table>
            <tr><th>Name</th><th>Type</th></tr>
            <asp:Repeater ID="Repeater1" ItemType="Events.ModuleDescription" 
                SelectMethod="GetModules" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><span><%#: Item.Name %></span></td>
                        <td><%#: Item.TypeName %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</body>
</html>
