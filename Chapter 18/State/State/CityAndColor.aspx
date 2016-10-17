<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="CityAndColor.aspx.cs" Inherits="State.CityAndColor" 
    EnableViewState="false" EnableSessionState="True" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        div.section { margin: 10px 0;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="section">
            Select a Color:
            <asp:DropDownList ID="colorSelect" ItemType="System.String" 
                SelectMethod="GetColors" runat="server" />
        </div>

        <div class="section">
            Select a City:
            <asp:DropDownList ID="citySelect" ItemType="System.String" 
                SelectMethod="GetCities" runat="server" />        
        </div>
        <div class="section">
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
