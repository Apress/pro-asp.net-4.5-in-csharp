<%@ Page Language="C#" AutoEventWireup="true" 
    EnableViewState="true" ViewStateMode="Enabled"
    CodeBehind="HistoryCalc.aspx.cs" Inherits="ControlState.HistoryCalc" %>

<%@ Register TagPrefix="CC" TagName="Calc" Src="~/Custom/Calc.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <CC:Calc runat="server" ViewStateMode="Disabled" />
    </form>
</body>
</html>
