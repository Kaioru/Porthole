<%@ Page Language="C#" MasterPageFile="Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Students" CodeBehind="~/Students.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<%@ Import Namespace="MoreLinq" %>
<% if (Children.Count > 0) { %>
    <div class="divider" data-content="child"></div>
    <% foreach (var batch in Children.Batch(4)) { %>
        <div class="list-columns columns">
        <% foreach (var student in batch) { %>
            <a href="Student.aspx?id=<%= student.ID %>" class="col-md-12 col-3 tile tile-centered">
                <div class="tile-icon">
                    <figure class="avatar avatar-md" data-initial="<%= student.Initials %>">
                        <img src="/Content/Avatars/<%= student.Photo %>" onerror="this.style.display='none'">
                    </figure>
                </div>
                <div class="tile-content">
                    <p class="tile-title"><%= student.Name %></p>
                    <small class="text-gray"><%= student.Course %></small>
                </div>
            </a>
        <% } %>
        </div>
        <small class="text-gray">can't find your child here? send a request to an
            <a href="#">administrator</a>!</small>
        <br />
        <br />
    <% } %>
<% } %>

<% if (PublicStudents.Count > 0) { %>
    <div class="divider" data-content="public"></div>
    <% foreach (var batch in PublicStudents.Batch(4)) { %>
        <div class="list-columns columns">
        <% foreach (var student in batch) { %>
            <a href="Student.aspx?id=<%= student.ID %>" class="col-md-12 col-3 tile tile-centered">
                <div class="tile-icon">
                    <figure class="avatar avatar-md" data-initial="<%= student.Initials %>">
                        <img src="/Content/Avatars/<%= student.Photo %>" onerror="this.style.display='none'">
                    </figure>
                </div>
                <div class="tile-content">
                    <p class="tile-title"><%= student.Name %></p>
                    <small class="text-gray"><%= student.Course %></small>
                </div>
            </a>
        <% } %>
        </div>
    <% } %>
<% } %>
</asp:Content>