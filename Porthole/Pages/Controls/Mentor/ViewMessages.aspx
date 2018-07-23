<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Mentor.ViewMessages" CodeBehind="~/ViewMessages.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<%@ Import Namespace="System.Linq" %>
<% if (Messages.Count > 0 ) { %>
    <div class="divider" data-content="messages"></div>
    <br />
    <% foreach (var message in Messages) { %>
        <div class="tile">
            <div class="tile-icon">
                <figure class="avatar avatar-lg" data-initial="<%= message.Parent.Initials %>">
                </figure>
            </div>
            <div class="tile-content">
                <p class="tile-title"><%=message.Title%>&nbsp;
                    <small>by <%=message.Parent.Name%></small>
                </p>
                <p class="tile-subtitle text-gray col-10"><%=message.Text%></p>
            </div>
            <div class="tile-action">
                <a href="ViewMessage.aspx?id=<%= message.ID %>" class="btn">
                    <i class="icon icon-edit"></i>
                </a>
            </div>
        </div>
    <% } %>
<% } %>
</asp:Content>