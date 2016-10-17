<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="ListV.aspx.cs" Inherits="Data.ListV" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles.css" />
</head>
<body>
<form id="form1" runat="server">
    <asp:ListView ID="lv" runat="server"
        ItemType="Data.Models.Product" SelectMethod="GetProducts" 
        UpdateMethod="UpdateProduct" DataKeyNames="ProductID">
        <LayoutTemplate>
            <table class="listViewTable">
                <tr>
                    <th><asp:LinkButton CommandName="Sort" CommandArgument="ProductID" Text="ID" 
                        runat="server"/></th>
                    <th><asp:LinkButton CommandName="Sort" CommandArgument="Name" Text="Name" 
                        runat="server"/></th>
                    <th>Category</th>
                    <th><asp:LinkButton CommandName="Sort" CommandArgument="Price" Text="Price" 
                        runat="server"/></th>
                </tr>
                <tr id="itemPlaceholder" runat="server"/>
                <tr>
                    <td colspan="5">
                        <asp:DataPager PageSize="4" runat="server">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" 
                                    ShowFirstPageButton="true" ShowPreviousPageButton="true"
                                    ShowNextPageButton="false" ShowLastPageButton="false"/>
                                <asp:NumericPagerField />
                                <asp:NextPreviousPagerField ButtonType="Button" 
                                    ShowLastPageButton="true" ShowNextPageButton="true"
                                    ShowFirstPageButton="false" ShowPreviousPageButton="false"/>
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Item.ProductID %></td>
                <td><%# Item.Name %></td>
                <td><%# Item.Category %></td>
                <td class="price"><%# Item.Price.ToString("F2") %></td>
                <td>
                    <asp:Button CommandName="Edit" Text="Edit" runat="server" />
                </td>
            </tr>
        </ItemTemplate>
        <EditItemTemplate>
            <tr>
                <td class="error" colspan="5">
                    <asp:ValidationSummary 
                        DisplayMode="SingleParagraph"
                        runat="server" />
                </td>
            </tr>
            <tr>
                <td><%# Item.ProductID %></td>
                <td><input id="name" runat="server" value="<%# BindItem.Name %>" /></td>
                <td>
                 <input id="category" runat="server" value="<%# BindItem.Category %>" />
                </td>
                <td>
                    <input id="price" runat="server" value="<%# BindItem.Price %>" />
                </td>
                <td>
                    <asp:Button CommandName="Update" Text="Save" runat="server" />
                    <asp:Button CommandName="Cancel" Text="Cancel" runat="server" />
                </td>
            </tr>
        </EditItemTemplate>
    </asp:ListView>
</form>
</body>
</html>
