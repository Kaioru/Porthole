<%@ Page Language="C#" MasterPageFile="Layouts/DefaultTemplate.master" Inherits="Porthole.Pages.Logout" CodeBehind="~/Logout.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="server">
<h1>done already?</h1>
<p class="text-error">are you sure you want to logout?</p>

<form runat="server">
    <a href="Students.aspx" class="btn">no</a>
    <asp:Button runat="server" id="btnLogout" OnClick="btnLogout_Click" class="btn btn-primary" Text="yup" />
</form>
</asp:Content>