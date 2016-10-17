<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="RepeaterCommands.aspx.cs" Inherits="OtherControls.RepeaterCommands" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div { margin-bottom: 10px;}
        table, th, td {
            border: thin solid black;
            border-collapse: collapse;
            padding: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Selected value: <span id="selectedValue" runat="server">None</span>
    </div>
    <div>
        <asp:Repeater ID="rep" ItemType="System.String" 
                SelectMethod="GetData" runat="server">
            <HeaderTemplate>
                <table>
                    <tr><th>Value</th><th>Select</th></tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Item %></td>
                    <td>
                        <asp:LinkButton runat="server"                          
                           Text="Select" CommandName="Select" 
                           CommandArgument="<%# Item %>" />
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
