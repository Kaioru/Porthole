<%@ Control Language="C#" Inherits="Porthole.Pages.Layouts.BreadCrumb" CodeBehind="~/BreadCrumb.ascx.cs"%>
<ul class="breadcrumb">
    <% foreach (var crumb in CurrentCrumbs) { %>
        <li class="breadcrumb-item">
            <a href="<%= crumb.Page %>"><%= crumb.Title %></a>
        </li>
    <% } %>
</ul>