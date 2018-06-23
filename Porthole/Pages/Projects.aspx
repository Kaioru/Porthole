<%@ Page Language="C#" MasterPageFile="Layouts/DefaultTemplate.master" Inherits="Porthole.Pages.Projects" CodeBehind="~/Projects.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="server">
<h1>projects</h1>
<%@ Import Namespace="MoreLinq" %>
<div class="divider" data-content="new"></div>
<% foreach (var batch in PublicProjects.Batch(2)) { %>
    <div class="list-columns columns">
    <% foreach (var project in batch) { %>
        <a href="Project.aspx?id=<%= project.ID %>" class="col-6 tile tile-centered">
            <div class="tile-icon">
                <figure class="avatar avatar-lg">
                    <img src="/Content/Posters/<%= project.Poster %>" />
                </figure>
            </div>
            <div class="tile-content">
                <p class="tile-title"><%= project.Title %>
                </p>
                <p class="tile-subtitle text-gray"><%= project.Description %></p>
            </div>
        </a>
    <% } %>
    </div>
<% } %>
</asp:Content>