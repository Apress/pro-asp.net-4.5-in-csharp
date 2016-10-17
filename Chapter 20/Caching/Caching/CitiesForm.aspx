<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CitiesForm.aspx.cs" Inherits="Caching.CitiesForm" %>

<%@ OutputCache Duration="60" VaryByParam="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    Here are some cities:
    <%= GetCities() %>
    (Rendered at <%: DateTime.Now.ToLongTimeString() %>)
</body>
</html>
