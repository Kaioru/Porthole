<%@ Page Language="C#" MasterPageFile="Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Projects" CodeBehind="~/Projects.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<%@ Import Namespace="MoreLinq" %>
<div class="divider" data-content="new"></div>
<% foreach (var batch in PublicProjects.Batch(2)) { %>
    <div class="list-columns columns">
    <% foreach (var project in batch) { %>
        <a href="Project.aspx?id=<%= project.ID %>" class="col-md-12 col-6 tile tile-centered">
            <div class="tile-icon">
                <figure class="avatar avatar-lg" data-initial="<%= project.Initials %>">
                    <img src="/Content/Posters/<%= project.Poster %>" onerror="this.style.display='none'">
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