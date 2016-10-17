<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" Inherits="Models.Default" %>

<%@ Register TagPrefix="CC" Assembly="Binding" Namespace="Binding.Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        label {display: inline-block;width: 100px;text-align: right; margin: 5px;}
        div.panel {float: left;margin-left: 10px;}
        div.panel label { text-align: right;}
        div.error, span.error { color: red;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ValidationSummary CssClass="error" runat="server"  
            HeaderText="There are problems with the data you entered:"/>
        <div class="panel">
            <div>
                <label>Your name:</label><input id="name" runat="server" />
                <CC:FieldValidator PropertyName="Name" CssClass="error" runat="server" />
            </div>
            <div>
                <label>Your age:</label><input id="age" runat="server" />
                <CC:FieldValidator PropertyName="Age" CssClass="error" runat="server" />
            </div>
            <div>
                <label>Your cell no:</label><input id="cell" runat="server" />
                <CC:FieldValidator PropertyName="Cell" CssClass="error" runat="server" />
            </div>
            <div>
                <label>Your zip code:</label><input id="zip" runat="server"/>
                <CC:FieldValidator PropertyName="Zip" CssClass="error" runat="server" />
            </div>
            <button type="submit">Submit</button>
        </div>
        <div class="panel">
            <asp:Repeater SelectMethod="GetData" ItemType="Binding.Models.Person" 
                ViewStateMode="Disabled" runat="server">
                <ItemTemplate>
                    <div><label>Your name:</label><span><%# Item.Name %></span></div>
                    <div><label>Your age:</label><span><%# Item.Age %></span></div>
                    <div><label>Your cell no:</label><span><%# Item.Cell %></span></div>
                    <div><label>Your zip code:</label><span><%# Item.Zip %></span></div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>