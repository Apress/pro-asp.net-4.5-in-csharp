<%@ Page Language="C#" AutoEventWireup="true" Async="true"
    CodeBehind="Multiples.aspx.cs" Inherits="AsyncApp.Multiples" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        table { border: thin solid black; border-collapse: collapse;}
        th, td { text-align: left; padding: 5px; border: thin solid black;}
    </style>
</head>
<body>
    <table>
        <tr><th>Start Time</th><th>URL</th><th>Length</th></tr>
        <asp:Repeater id="rep" SelectMethod="GetResults" 
                ItemType="AsyncApp.MultiWebSiteResult" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Item.StartTime %></td>
                    <td><%# Item.Url %></td>
                    <td><%# Item.Length %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</body>
</html>
