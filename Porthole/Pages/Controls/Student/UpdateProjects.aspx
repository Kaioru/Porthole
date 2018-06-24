<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Student.UpdateProjects" CodeBehind="~/UpdateProjects.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<% if (OwnedProjects.Count > 0 ) { %>
    <div class="divider" data-content="projects you own"></div>
    <br />
    <% foreach (var project in OwnedProjects) { %>
        <div class="tile">
            <div class="tile-icon">
                <figure class="avatar avatar-lg">
                    <img src="/Content/Posters/<%= project.Poster %>" />
                </figure>
            </div>
            <div class="tile-content">
                <p class="tile-title"><%=project.Title%>
                    &nbsp;
                    <small>
                        <span class="chip">Owner</span>
                    </small>
                </p>
                <p class="tile-subtitle text-gray col-10"><%=project.ShortDescription%></p>
            </div>
            <div class="tile-action">
                <a href="UpdateProject.aspx?id=<%= project.ID %>" class="btn">
                    <i class="icon icon-edit"></i>
                </a>
            </div>
        </div>
    <% } %>
<% } %>

<% if (RelatedProjects.Count > 0 ) { %>
    <div class="divider" data-content="projects you're apart of"></div>
    <br />
    <% foreach (var project in RelatedProjects) { %>
        <div class="tile">
            <div class="tile-icon">
                <figure class="avatar avatar-lg">
                    <img src="/Content/Posters/<%= project.Poster %>" />
                </figure>
            </div>
            <div class="tile-content">
                <p class="tile-title"><%=project.Title%></p>
                <p class="tile-subtitle text-gray col-10"><%=project.ShortDescription%></p>
            </div>
            <div class="tile-action">
                <a href="UpdateProjectReflections.aspx?id=<%= project.ID %>" class="btn">
                    <i class="icon icon-edit"></i>
                </a>
            </div>
        </div>
    <% } %>
<% } %>

<br />
<div>
    <a href="CreateProject.aspx" class="btn btn-primary">create project</a>
</div>
</asp:Content>