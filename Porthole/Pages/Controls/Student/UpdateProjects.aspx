<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Student.UpdateProjects" CodeBehind="~/UpdateProjects.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<%@ Import Namespace="System.Linq" %>
<% if (OwnedProjects.Count > 0 ) { %>
    <div class="divider" data-content="projects you own"></div>
    <br />
    <% foreach (var project in OwnedProjects) { %>
        <div class="tile">
            <div class="tile-icon">
                <figure class="avatar avatar-lg" data-initial="<%= project.Initials %>">
                    <img src="/Content/Posters/<%= project.Poster %>" onerror="this.style.display='none'">
                </figure>
            </div>
            <div class="tile-content">
                <p class="tile-title"><%=project.Title%>
                    &nbsp;
                    <small>
                        <span class="chip">Owner</span>
                    </small>
                    <% var reflection = project.ProjectMembers.Single(m => m.Student.ID == CurrentStudent.ID).Reflection; %>
                    <% if (reflection != null) { %>
                        <br />
                        <small class="text-gray">'<%= reflection %>'</small>
                    <% } %>
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
    <div class="divider" data-content="projects you're a part of"></div>
    <br />
    <% foreach (var project in RelatedProjects) { %>
        <div class="tile">
            <div class="tile-icon">
                <figure class="avatar avatar-lg" data-initial="<%= project.Initials %>">
                    <img src="/Content/Posters/<%= project.Poster %>" onerror="this.style.display='none'">
                </figure>
            </div>
            <div class="tile-content">
                <p class="tile-title"><%=project.Title%>
                    <% var reflection = project.ProjectMembers.Single(m => m.Student.ID == CurrentStudent.ID).Reflection; %>
                    <% if (reflection != null) { %>
                        <br />
                        <small class="text-gray">'<%= reflection %>'</small>
                    <% } %>
                </p>
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