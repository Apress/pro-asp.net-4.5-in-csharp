<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="SecondPage.aspx.cs" Inherits="RequestControl.SecondPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        This is SecondPage.aspx    
        <p>Handler: <%: Context.Handler %> </p>
        <p>CurrentHandler: <%: Context.CurrentHandler %> </p>
        <p>PreviousHandler: <%: Context.PreviousHandler %> </p>

    </div>
    </form>
</body>
</html>
