<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Select.aspx.cs" Inherits="ServerSideHtml.Select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div {margin-top: 10px;}</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Pick a color: 
            <select id="colorSelect" runat="server">
                <option value="red">Red</option>                
                <option value="green" selected="selected">Green</option>
                <option value="blue">Blue</option>
            </select>
        </div>
        <div id="container" runat="server">
            Pick a color: 
        </div>
        <button type="submit">Submit</button>        
    </form>
</body>
</html>
