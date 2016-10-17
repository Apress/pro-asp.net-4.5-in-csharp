<%@ Control Language="C#" AutoEventWireup="true" 
    CodeBehind="Counter.ascx.cs" Inherits="ControlState.Custom.Counter" %>

<div>Left Counter: <%= LeftValue %></div>
<div>Right Counter: <%= RightValue %></div>
<div>
    <button name="<%= GetId("button") %>" value="<%= GetId("left") %>">Left</button>
    <button name="<%= GetId("button") %>" value="<%= GetId("right") %>">Right</button>
</div>
