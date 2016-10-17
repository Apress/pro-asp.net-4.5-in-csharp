<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Data.aspx.cs" Inherits="ClientDev.Data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        th { text-align: left; border-bottom: thin solid black;}
        input[type=text][name=Price] { width: 75px;}
        input[type=text][name=Category] { width: 100px;}
        .error { color: red;}
    </style>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/jquery") %>
    <script src="Scripts/Data.js"></script>
    <script type="text/template" id="rowTemplate">
        <tr>
            <td>{ProductID}</td>
            <td><input type="text" name="Name" Value="{Name}"></td>
            <td><input type="text" name="Category" Value="{Category}"></td>
            <td><input type="text" name="Price" Value="{Price}"></td>
            <td>
                <button data-id={ProductID} data-action="update">Update</button>
                <button data-id={ProductID} data-action="delete">Delete</button>
            </td>
        </tr>
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table id="dataTable">
            <thead>
                <tr>
                    <th>ID</th><th>Name</th><th>Category</th><th>Price</th>
                    <th></th>
                </tr>
            </thead>
            <tbody></tbody>
        </table>
    </form>
</body>
</html>
