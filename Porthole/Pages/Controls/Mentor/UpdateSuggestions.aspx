<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Mentor.UpdateSuggestions" CodeBehind="~/UpdateSuggestions.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<div class="container">
    <div class="panel" style="height: 28rem">
        <div class="panel-header">
            <div class="panel-title h6">Suggestions</div>
        </div>
        <div class="panel-body">
            <% foreach(var suggestion in Suggestions) { %>
            <div class="tile">
                <div class="tile-icon">
                    <figure class="avatar avatar-sm" data-initial="<%= suggestion.Mentor.Initials %>">
                    </figure>
                </div>
                <div class="tile-content">
                    <p class="tile-title"><%= suggestion.Mentor.Name %>&nbsp;
                        <% if (suggestion.Status.Equals("Y")) { %>
                            <small><i class="icon icon-check"></i></small>
                        <% } %>
                    </p>
                    <p class="tile-subtitle"><%= suggestion.Description %></p>
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
            </form>
            <asp:RequiredFieldValidator runat="server" 
                ControlToValidate="txtInput"
                ErrorMessage="input is required">&nbsp;
            </asp:RequiredFieldValidator>
            <asp:ValidationSummary runat="server" />
        </div>
    </div>
</div>
</asp:Content>