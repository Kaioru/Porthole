<%@ Page Language="C#" MasterPageFile="Layouts/Template.master" Inherits="Porthole.Default" CodeBehind="~/Default.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" Runat="server">
    <% foreach (var student in Students) { %>
        <p><%= student.Mentor.Password %></p>
    <% } %>
</asp:Content>