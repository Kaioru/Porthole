<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Mentor.ViewSuggestions" CodeBehind="~/ViewSuggestions.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<%@ Import Namespace="System.Linq" %>
<% if (Mentees.Count > 0 ) { %>
    <div class="divider" data-content="mentees"></div>
    <br />
    <%@ Import Namespace="MoreLinq" %>
    <% foreach (var batch in Mentees.Batch(4)) { %>
        <div class="columns">
        <% foreach (var student in batch) { %>
            <a href="/Pages/Controls/Mentor/UpdateSuggestions.aspx?id=<%= student.ID %>" class="col-3 tile tile-centered">
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