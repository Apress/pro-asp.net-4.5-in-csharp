<%@ Page Language="C#" AutoEventWireup="true" ViewStateMode="Disabled"
    CodeBehind="Manage.aspx.cs" Inherits="ManagingUsers.Admin.Manage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {margin: 10px 0;}
        th, td { text-align: left; padding: 5px 5px 5px 0;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Manage Users</h3>
        <div>There are <%: Membership.GetNumberOfUsersOnline() %> users online.</div>
        <div>
            <table>
                <tr><th>Name</th><th>Roles</th><th>Locked</th>
                    <th>Online</th><th></th><th></th></tr>
                <asp:Repeater ItemType="ManagingUsers.Admin.UserDetails" 
                        SelectMethod="GetUsers" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Item.Name %></td>
                            <td><%# Item.Roles %> </td>
                            <td><%# Item.Locked%> </td>
                            <td><%# Item.Online %> </td>
                            <td><button type="submit"  name="unlock" 
                                value="<%# Item.Name %>">Unlock</button>   </td>
                            <td><button type="submit"  name="delete" 
                                value="<%# Item.Name %>">Delete</button>   </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </form>
</body>
</html>
