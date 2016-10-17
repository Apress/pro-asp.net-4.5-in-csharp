<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="SelectCity.aspx.cs" Inherits="ConfigFiles.SelectCity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <label>Pick a city:</label>
    <select>
        <asp:Repeater ID="Repeater1" SelectMethod="GetPlaces" 
                ItemType="ConfigFiles.Place" runat="server">
            <ItemTemplate>
                <option value="<%# Item.Code %>"><%# Item.City %>, 
                    <%# Item.Country %></option>
            </ItemTemplate>
        </asp:Repeater>
    </select>
</body>
</html>
