<%@ Control Language="C#" AutoEventWireup="true" 
    CodeBehind="CitiesControl.ascx.cs" Inherits="Caching.CitiesControl" %>

Here are some cities:
<%= GetCities() %>
(Rendered at <%= GetTimeStamp() %>)
