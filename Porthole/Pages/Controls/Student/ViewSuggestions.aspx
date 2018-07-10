<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Student.ViewSuggestions" CodeBehind="~/ViewSuggestions.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<% if (NewSuggestions.Count > 0) { %>
    <div class="divider" data-content="new"></div>
    <% foreach (var suggestion in NewSuggestions) { %>
    <div class="tile">
        <div class="tile-icon">
            <figure class="avatar avatar-md" data-initial="<%= suggestion.Mentor.Initials %>">
            </figure>
        </div>
        <div class="tile-content">
            <p class="tile-title"><%= suggestion.Mentor.Name %>
                <br />
                <small class="text-gray"><%= suggestion.DateCreated.ToString("dd MMM yy, hh:mm tt") %></small>
            </p>
            <p class="tile-subtitle text-gray col-10"><%= suggestion.Description %></p>
        </div>
        <div class="tile-action">
            <a href="ViewSuggestions.aspx?ack=<%= suggestion.ID %>" class="btn">
                <i class="icon icon-check"></i>
            </a>
        </div>
    </div>
    <% } %>
<% } %>

<% if (OldSuggestions.Count > 0) { %>
    <div class="divider" data-content="acknowledged"></div>
    <% foreach (var suggestion in OldSuggestions) { %>
    <div class="tile">
        <div class="tile-icon">
            <figure class="avatar avatar-md" data-initial="<%= suggestion.Mentor.Initials %>">
            </figure>
        </div>
        <div class="tile-content">
            <p class="tile-title"><%= suggestion.Mentor.Name %>
                <br />
                <small class="text-gray"><%= suggestion.DateCreated.ToString("dd MMM yy, hh:mm tt") %></small>
            </p>
            <p class="tile-subtitle text-gray col-10"><%= suggestion.Description %></p>
        </div>
    </div>
    <% } %>
<% } %>

<% if (NewSuggestions.Count + OldSuggestions.Count == 0) { %>
<div class="empty">
    <div class="empty-icon">
        <i class="icon icon-message"></i>
    </div>
    <p class="empty-title h5">no suggestions.</p>
    <p class="empty-subtitle">maybe you're just too good.</p>
</div>
<% } %>
</asp:Content>