<%@ Page Language="C#" AutoEventWireup="true"  
    CodeBehind="Default.aspx.cs" Inherits="ErrorHandling.Default" %>

<%@ Register TagPrefix="CC" TagName="Sum" Src="~/SumControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        div.panel {margin-bottom: 5px; clear: both;}
        div.panel label, div.panel input:not([type=checkbox])  {
            display:inline-block;width: 110px;}
        div.wrapper {border: thin solid black; margin-right: 5px; margin-bottom: 
            5px; padding: 5px; float: left; height: 150px; min-width: 100px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper"><h3>Page</h3>
            <div class="panel">
                <input type="checkbox" name="pageAction" value="error" />
                Generate Error
            </div>
        </div>
        <div class="wrapper">
            <h3>Control</h3>
            <CC:Sum ID="sumControl" runat="server" />
        </div>
        <div class="panel"><button type="submit">Submit</button></div>
    </form>
</body>
</html>
