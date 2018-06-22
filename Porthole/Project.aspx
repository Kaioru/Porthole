<%@ Page Language="C#" MasterPageFile="Layouts/Template.master" Inherits="Porthole.Project" CodeBehind="~/Project.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphMain" Runat="server">
<div class="headbar">
    <div class="tile tile-centered">
        <div class="tile-icon">
            <img src="<%= CurrentProject.Poster %>" class="avatar avatar-main" alt="avatar">
        </div>
        <div class="tile-content">
            <ul class="breadcrumb">
                <li class="breadcrumb-item">
                    <a href="Students.aspx">home</a>
                </li>
                <li class="breadcrumb-item">
                    <a href="Projects.aspx">project</a>
                </li>
                <li class="breadcrumb-item">
                    <a href="Projects.aspx?id=<%= CurrentProject.ID %>"><%= CurrentProject.Title.ToLower() %></a>
                </li>
            </ul>
            <h1><%= CurrentProject.Title %></h1>
            <p class="tile-subtitle text-gray col-8"><%= CurrentProject.Description %></p>
        </div>
    </div>
</div>

<div class="content">
    <ul class="menu menu-nav content-nav">
        <div class="container">
            <li class="menu-item">
                <a href="#about"># about</a>
                <a href="#collaborators"># collaborators</a>
            </li>
        </div>
    </ul>

    <div class="container">
        <a id="about"></a>
        <h2>about</h2>
        <%@ Import Namespace="Markdig" %>
        <div class="col-8"><%= Markdown.ToHtml(CurrentProject.Description) %></div>
    </div>

    <div class="container">
        <a id="collaborators"></a>
        <h2>collaborators</h2>
        <div>
            <% foreach (var pivot in CurrentProject.ProjectMembers) { %>
            <% var student = pivot.Student; %>
                <% if (student.Status.Equals("Y")) { %>
                    <a href="Student.aspx?id=<%= student.ID %>" class="tile tile-centered">
                        <div class="tile-icon">
                            <figure class="avatar avatar-md">
                                <img src="<%= student.Photo %>" />
                            </figure>
                        </div>
                        <div class="tile-content">
                            <p class="tile-title"><%= student.Name %>
                                <% if (pivot.Role.Equals("Leader")) { %>
                                    &nbsp;
                                    <small>
                                        <span class="chip">Owner</span>
                                    </small>
                                <% } %>
                            </p>
                            <small class="text-gray">'<%= pivot.Reflection %>'</small>
                        </div>
                    </a>
                <% } %>
            <% } %>
        </div>
        <%@ Import Namespace="System.Linq" %>
        <small class="text-gray">..and <%= CurrentProject.ProjectMembers.Count(pm => pm.Student.Status.Equals("Y")) %> more private collaborators</small>
    </div>

    <div class="container">
        <%@ Register Src="Layouts/Footer.ascx" TagName="Footer" TagPrefix="partial" %> 
        <partial:Footer runat="server" />
    </div>
</div>
</asp:Content>