<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" Inherits="Data.Default" %>

<%@ Register TagPrefix="CC" Assembly="Data" Namespace="Data.Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> 
        div { margin-bottom: 10px;}
        th, td { text-align: left;}
        td {padding-bottom: 5px;}
        th, table { border-bottom: solid thin black;}
        th:last-child, td:last-child { text-align: right;}
        body { font-family: "Arial Narrow", sans-serif;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <CC:DataTable ItemType="Data.Models.Product" SelectMethod="GetProductData"
                    runat="server">
                <HeaderTemplate>
                    <tr><th>Name</th><th>Category</th><th>Price</th></tr>
                </HeaderTemplate>
                <RowTemplate>
                    <tr>
                        <td><%#: Item.Name %></td>
                        <td><%#: Item.Category %></td>
                        <td><%#: Item.Price.ToString("F2") %></td>
                    </tr>
                </RowTemplate>
            </CC:DataTable>
        </div>
        <div>Filter:
            <CC:DataSelect id="dSelect" ItemType="Data.Models.Product" 
                    SelectMethod="GetCategories" runat="server" >
                <ItemTemplate>
                    <option <%# Container.GenerateSelect(Item.Category) %>>
                        <%# Item.Category %>
                    </option>
                </ItemTemplate>
            </CC:DataSelect>
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
