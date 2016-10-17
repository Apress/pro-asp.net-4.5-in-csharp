<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" Inherits="WorkingWithControls.Default" %>

<%@ Register TagPrefix="CC"  TagName="UCButton" Src="~/ButtonCountUserControl.ascx" %>
<%@ Register Assembly="WorkingWithControls" TagPrefix="SC" 
    Namespace="WorkingWithControls" %>
<%@ Register TagPrefix="CC"  TagName="UCTriple" Src="~/TripleButtonControl.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style> div { margin-top: 10px;} </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Button presses: <span id="counter" runat="server"></span>
        </div>
        <div>
            <button type="submit">Submit</button>
        </div>
        <CC:UCButton ID="userControl" runat="server" />
        <SC:ButtonCounterServerControl ID="serverControl" runat="server" />
        <CC:UCTriple ID="tripleControl" runat="server" />
        <div>
            UI Button presses: 
            <asp:Label ID="uiLabel" Font-Bold="true" Font-Size="Larger" 
                runat="server" Text="0" />
        </div>
        <div>
            <asp:Button ID="uiButton" Text="Submit (UI)" 
                OnClick="ButtonClick" runat="server" ViewStateMode="Disabled" />
        </div>
    </form>
</body>
</html>