<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="SimpleTable.aspx.cs" Inherits="ServerSideHtml.SimpleTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table { border: thin solid black; }
        td, th { padding: 2px 5px; }
        thead > tr { border: solid thin black;}
        td:last-child, th:last-child { text-align: right;}
        div { margin-bottom: 10px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table id="colorTable" runat="server">
                <thead><tr><th>Color</th><th>Count</th></tr></thead>
                <tbody>
                    <tr><td>Red</td><td>2</td></tr>
                    <tr><td>Green</td><td id="greenCell" runat="server">41</td></tr>
                    <tr><td>Blue</td><td>3</td></tr>
                </tbody>
                <tfoot>
                    <tr><th>Total:</th><th id="totalCell" runat="server">46</th></tr>
                </tfoot>
            </table>    
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
