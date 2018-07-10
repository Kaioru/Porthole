<%@ Control Language="C#" Inherits="Porthole.Pages.Layouts.BreadCrumb" CodeBehind="~/BreadCrumb.ascx.cs"%>
<% 
var LastCrumb = CurrentCrumbs[CurrentCrumbs.Count - 1];
if (LastCrumb.Title != null) {
%>
    <h1><%= LastCrumb.Title %></h1>
<% } %>
<ul class="breadcrumb">
    <%@ Import Namespace="System.Linq" %>
    <% var last = CurrentCrumbs.Last(); %>
    <% foreach (var crumb in CurrentCrumbs) { %>
        <li class="breadcrumb-item">
            <% if (crumb.Equals(last)) { %>
                <a href="<%= HttpContext.Current.Request.Url.PathAndQuery %>"><%= crumb.Title %></a>
            <% } else { %>
                <a href="<%= crumb.Page %>"><%= crumb.Title %></a>
            <% } %>
        </li>
    <% } %>
</ul>