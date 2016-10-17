<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" 
    Inherits="State.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        button { margin: 10px 0; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            This page has been displayed <%: GetCounter() %> time(s).
        </div> 
        <button type="submit">Submit</button>
    </form>
</body>
</html>