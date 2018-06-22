<%@ Page Language="C#" MasterPageFile="Layouts/DefaultTemplate.master" Inherits="Porthole.Settings" CodeBehind="~/Settings.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="server">
<h1>settings</h1>

<div class="tile tile-centered">
    <div class="tile-icon">
        <img src="" class="avatar avatar-main" alt="avatar">
    </div>
    <div class="tile-content">
        <h1><%= Account.EmailAddress %></h1>
        <p class="tile-subtitle text-gray">this is the settings page where you can set all your tings!</p>
    </div>
</div>
<br />

<div class="divider" data-content="<%= AccountType %>"></div>
<%@ Import Namespace="MoreLinq" %>
<% foreach (var batch in Options.Batch(4)) { %>
    <div class="list-columns columns">
        <% foreach (var option in batch) { %>
            <a href="<%= option.Redirect %>" class="col-3 tile tile-centered">
                <div class="tile-icon">
                    <figure class="avatar avatar-md">
                        <img/>
                    </figure>
                </div>
                <div class="tile-content">
                    <p class="tile-title"><%= option.Option %></p>
                </div>
            </a>
        <% } %>
    </div>
<% } %>
</asp:Content>