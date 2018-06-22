﻿<%@ Page Language="C#" MasterPageFile="Layouts/Template.master" Inherits="Porthole.Student" CodeBehind="~/Student.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" Runat="server">
 <div class="off-canvas off-canvas-sidebar-show">
    <a class="off-canvas-toggle btn btn-primary btn-action" href="#sidebar-main">
        <i class="icon icon-menu"></i>
    </a>

    <div id="#sidebar-main" class="off-canvas-sidebar">
        <!-- off-screen sidebar -->
        <div class="sidebar-container">
            <img src="<%= CurrentStudent.Photo %>" class="img-responsive avatar avatar-main" />
        </div>

        <div class="sidebar-container">
            <h2><%= CurrentStudent.Name %></h2>
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
                <a href="Default.aspx">home</a>
            </li>
            <li class="breadcrumb-item">
                <a href="Default.aspx">portfolio</a>
            </li>
            <li class="breadcrumb-item">
                <a href="Student.aspx?id=<%= CurrentStudent.ID %>"><%= CurrentStudent.Name.ToLower() %></a>
            </li>
        </ul>

        <br />

        <div class="container">
            <a id="about"></a>
            <h2>about</h2>
            <p><%= CurrentStudent.Description %></p>
        </div>

        <div class="container">
            <a id="skills"></a>
            <h2>skills</h2>
            <% foreach (var pivot in CurrentStudent.StudentSkillSets) { %>
                <% var skillset = pivot.SkillSet; %>
                <div class="chip">
                    <img src="" class="avatar avatar-sm"> <%= skillset.Name %>
                </div>
            <% } %>
        </div>

        <div class="container">
            <a id="projects"></a>
            <h2>projects</h2>
            <% foreach (var pivot in CurrentStudent.ProjectMembers) { %>
                <% var project = pivot.Project; %>
                <div class="tile">
                    <div class="tile-icon">
                        <figure class="avatar avatar-lg">
                            <img src="<%= project.Poster %>" />
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
                        </p>
                        <p class="tile-subtitle text-gray"><%= project.Description %></p>
                        <div class="d-inline">
                            <a href="Project.aspx?id=<%= project.ID %>" class="btn">visit project page</a>
                        </div>
                    </div>
                </div>
            <% } %>
        </div>

        <div class="container">
            <a id="contact"></a>
            <h2>contact</h2>
            <div class="tile">
                <div class="tile-icon">
                    <i class="far fa-file"></i>
                </div>
                <div class="tile-content">
                    <a class="tile-subtitle"><%= CurrentStudent.URL %></a>
                </div>
            </div>
        </div>

        <div class="container">
            <footer>
                <div class="divider"></div>
                <p>made with
                    <span class="text-error">♥</span> by
                    <a href="https://github.com/kaioru" target="_blank">kaioru</a>,
                    <a href="https://github.com/bokiex" target="_blank">bokiex</a>.</p>
            </footer>
        </div>
    </div>
</div>
</asp:Content>