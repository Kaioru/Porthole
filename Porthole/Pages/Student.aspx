<%@ Page Language="C#" MasterPageFile="Layouts/Template.master" Inherits="Porthole.Pages.Student" CodeBehind="~/Student.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" Runat="server">
 <div class="off-canvas off-canvas-sidebar-show">
    <a class="off-canvas-toggle btn btn-primary btn-action" href="#sidebar-main">
        <i class="icon icon-menu"></i>
    </a>

    <div id="#sidebar-main" class="off-canvas-sidebar">
        <!-- off-screen sidebar -->
        <div class="sidebar-container">
            <figure class="avatar avatar-main" data-initial="<%= CurrentStudent.Initials %>">
                <img src="/Content/Avatars/<%= CurrentStudent.Photo %>" onerror="this.style.display='none'">
            </figure>
        </div>

        <div class="sidebar-container">
            <h2><%= CurrentStudent.Name %></h2>
            <p class="text-gray"><%= CurrentStudent.Course %></p>
        </div>

        <div class="sidebar-container">
            <div class="divider"></div>
        </div>

        <div class="sidebar-container">
            <ul class="menu menu-nav">
                <li class="menu-item">
                    <a href="#about">about</a>
                    <a href="#skills">skills</a>
                    <a href="#projects">projects</a>
                    <a href="#contact">contact</a>
                </li>
            </ul>
        </div>
    </div>

    <a class="off-canvas-overlay" href="#close"></a>

    <div class="content off-canvas-content">
        <ul class="breadcrumb">
            <li class="breadcrumb-item">
                <a href="Home.aspx">home</a>
            </li>
            <li class="breadcrumb-item">
                <a href="Students.aspx">students</a>
            </li>
            <li class="breadcrumb-item">
                <a href="Student.aspx?id=<%= CurrentStudent.ID %>"><%= CurrentStudent.Name.ToLower() %></a>
            </li>
        </ul>

        <br />

        <div class="container">
            <a id="about"></a>
            <h2>about</h2>
            <%@ Import Namespace="Markdig" %>
            <div><%= Markdown.ToHtml(CurrentStudent.Description) %></div>
        </div>

        <% if (CurrentStudent.Achievement != null) { %>
            <div class="container">
                <a id="achievements"></a>
                <h2>achievements</h2>
                <div><%= Markdown.ToHtml(CurrentStudent.Achievement) %></div>
            </div>
        <% } %>

        <% if (CurrentStudent.StudentSkillSets.Count > 0) { %>
            <div class="container">
                <a id="skills"></a>
                <h2>skills</h2>
                <% foreach (var pivot in CurrentStudent.StudentSkillSets) { %>
                    <% var skillset = pivot.SkillSet; %>
                    <div class="chip"> 
                        <figure class="avatar avatar-sm" data-initial="<%= skillset.Initials %>">
                            <img src="/Content/Chips/<%= skillset.ID %>" onerror="this.style.display='none'">
                        </figure>
                        &nbsp;<%= skillset.Name %>
                    </div>
                <% } %>
            </div>
        <% } %>

        <% if (CurrentStudent.ProjectMembers.Count > 0) { %>
            <div class="container">
                <a id="projects"></a>
                <h2>projects</h2>
                <%@ Import Namespace="System.Linq" %>
                <% foreach (var pivot in CurrentStudent.ProjectMembers.OrderBy(m => m.Role).ToList()) { %>
                    <% var project = pivot.Project; %>
                    <div class="tile">
                        <div class="tile-icon">
                            <figure class="avatar avatar-lg" data-initial="<%= project.Initials %>">
                                <img src="/Content/Posters/<%= project.Poster %>" onerror="this.style.display='none'">
                            </figure>
                        </div>
                        <div class="tile-content">
                            <p class="tile-title"><%= project.Title %>
                                <% if (pivot.Role.Equals("Leader")) { %>
                                &nbsp;
                                <small>
                                    <span class="chip">Owner</span>
                                </small>
                                <% } %>
                                <% if (pivot.Reflection != null) { %>
                                    <br />
                                    <small class="text-gray">'<%= pivot.Reflection %>'</small>
                                <% } %>
                            </p>
                            <p class="tile-subtitle text-gray"><%= project.ShortDescription %></p>
                            <div class="d-inline">
                                <a href="Project.aspx?id=<%= project.ID %>" class="btn">visit project page</a>
                            </div>
                        </div>
                    </div>
                <% } %>
            </div>
        <% } %>

        <% if (CurrentStudent.URL != null) { %>
            <div class="container">
                <a id="contact"></a>
                <h2>contact</h2>
                <div class="tile">
                    <div class="tile-icon">
                        <i class="far fa-file"></i>
                    </div>
                    <div class="tile-content">
                        <a href="<%= CurrentStudent.URL %>" target="_blank" class="tile-subtitle"><%= CurrentStudent.URL %></a>
                    </div>
                </div>
            </div>
        <% } %>

        <div class="container">
            <%@ Register Src="Layouts/Footer.ascx" TagName="Footer" TagPrefix="partial" %> 
            <partial:Footer runat="server" />
        </div>
    </div>
</div>
</asp:Content>