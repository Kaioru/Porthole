<%@ Control Language="C#" Inherits="Porthole.Pages.Layouts.BreadCrumb" CodeBehind="~/BreadCrumb.ascx.cs"%>
<% 
var LastCrumb = CurrentCrumbs[CurrentCrumbs.Count - 1];
if (LastCrumb.Title != null) {
%>
    <h1><%= LastCrumb.Title %></h1>
<% } %>
<ul class="breadcrumb">
    <% foreach (var crumb in CurrentCrumbs) { %>
        <li class="breadcrumb-item">
            <a href="<%= crumb.Page %>"><%= crumb.Title %></a>
        </li>
    <% } %>
</ul>