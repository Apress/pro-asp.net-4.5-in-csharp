<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" 
    Inherits="PartyInvites.Pages.Summary" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="/Content/PartyStyles.css" />
</head>
<body>
    <h2>RSVP Summary</h2>
    <h3>People Who Will Attend</h3>
    <table>
        <thead><tr><th>Name</th><th>Email</th><th>Phone</th></tr></thead>
        <tbody><%= GetResponses(true) %></tbody>
    </table>
    <h3>People Who Will Not Attend</h3>
    <table>
        <thead><tr><th>Name</th><th>Email</th><th>Phone</th></tr></thead>
        <tbody><%= GetResponses(false) %></tbody>
    </table>
</body>
</html>
