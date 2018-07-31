<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Mentor.ViewMessage" CodeBehind="~/ViewMessage.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<div class="container">
    <div class="panel" style="height: 28rem">
        <div class="panel-header">
            <div class="panel-title h6"><%= CurrentMessage.Title %>&nbsp;
                <small>by <%=CurrentMessage.Parent.Name%></small>
            </div>
        </div>
        <div class="panel-body">
            <div class="tile">
                <div class="tile-icon">
                    <figure class="avatar avatar-sm" data-initial="<%= CurrentMessage.Parent.Initials %>">
                    </figure>
                </div>
                <div class="tile-content">
                    <p class="tile-title"><%= CurrentMessage.Parent.Name %>&nbsp;
                    </p>
                    <p class="tile-subtitle"><%= CurrentMessage.Text %></p>
                </div>
            </div>
            <%@ Import Namespace="Porthole.Models" %>
            <% foreach(var reply in Replies) { %>
            <% IAccount nugu = reply.Mentor; %>
            <% if (nugu == null) nugu = reply.Parent; %>
            <div class="tile">
                <div class="tile-icon">
                    <figure class="avatar avatar-sm" data-initial="<%= nugu.Initials %>">
                    </figure>
                </div>
                <div class="tile-content">
                    <p class="tile-title"><%= nugu.Name %>&nbsp;
                    </p>
                    <p class="tile-subtitle"><%= reply.Text %></p>
                </div>
            </div>
            <% } %>
        </div>
        <div class="panel-footer">
            <form runat="server">
                <div class="input-group">
                    <asp:TextBox runat="server" class="form-input" id="txtInput" placeholder="say something i'm giving up on you"></asp:TextBox>
                    <asp:Button runat="server" id="btnSend" OnClick="btnSend_Click" class="btn btn-primary input-group-btn" Text="Send" />
                </div>
                 <asp:RequiredFieldValidator runat="server" 
                    ControlToValidate="txtInput"
                    ErrorMessage="input is required">&nbsp;
                    </asp:RequiredFieldValidator>
                <asp:ValidationSummary runat="server" />
            </form> 
        </div>
    </div>
</div>
</asp:Content>