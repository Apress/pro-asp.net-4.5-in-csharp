<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="RequestControl.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>This is Default.aspx</h3>
        <div>
            <input type="radio" name="choice" 
                value="redirect302" checked="checked"/>Redirect
        </div>
        <div>
            <input type="radio" name="choice" value="redirect301" />Redirect Permanent
        </div>
        <div>
            <input type="radio" name="choice" value="remaphandler" />Remap Handler
        </div>
        <div>
            <input type="radio" name="choice" value="transferpage" />Transfer Page
        </div>
        <div>
            <input type="radio" name="choice" value="execute" />Execute Handlers
        </div>
        <p><button type="submit">Submit</button></p>
    </div>
    </form>
</body>
</html>
