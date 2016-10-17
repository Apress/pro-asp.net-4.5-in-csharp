<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="Simple.aspx.cs" Inherits="ClientDev.Simple" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <span class="message">This is Simple.aspx</span>
    </div>
    <div> Mobile: <%: Request.Browser.IsMobileDevice %> </div>
    <div>
        <button>Button 1</button>
        <button>Button 2</button>
    </div>
</asp:Content>
