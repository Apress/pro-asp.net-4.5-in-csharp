<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" Inherits="Controls.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        input { width: 100px;}
        div { margin-bottom: 10px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input name="firstNumber" value="10" /> +
            <input name="secondNumber" value="31" />
            <button type="submit">=</button>
            <span id="result" runat="server"></span>
        </div>
        <div>
            <CC:Calc id="Calc" Initial="100" runat="server">
                <Calculations>
                    <CC:Calculation operation="Plus" value="10" />
                    <CC:Calculation operation="Minus" value="20" />            
                </Calculations>
            </CC:Calc>
        </div>
        <div>
            <CC:ServerCalc Initial="100" runat="server">
                <Calculations>
                    <CC:Calculation operation="Plus" value="10" />
                    <CC:Calculation operation="Minus" value="20" />
                </Calculations>
            </CC:ServerCalc>
        </div>
    </form>
</body>
</html>
