<%@ Control Language="C#" AutoEventWireup="true" 
    CodeBehind="ButtonCountUserControl.ascx.cs" 
    Inherits="WorkingWithControls.ButtonCountUserControl" %>

<div>
    User Control Button presses: <span id="counter" runat="server"></span>
</div>
<div>
    <button name="button" value="userControl" type="submit">
    Submit (User Control)</button>
</div>
