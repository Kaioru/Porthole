<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Mentor.SearchStudents" CodeBehind="~/SearchStudents.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<div class="columns">
    <div class="column col-8">
        <form runat="server" class="form-horizontal">
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="txtName">name</label>
                </div>
                <div class="col-9 col-sm-12">
                <asp:TextBox runat="server" class="form-input" id="txtName" placeholder="who dat boi?"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="cblSkills">skills</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:CheckBoxList runat="server" id="cblSkills" RepeatDirection="Horizontal" RepeatColumns="3" RepeatLayout="Table" /> 
                </div>
            </div>

            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="input-mentees">limit to mentees</label>
                </div>
                <div class="col-9 col-sm-12">
                    <label class="form-switch">
                    <asp:CheckBox ID="cbMentees" runat="server" />
                        <i class="form-icon"></i>
                    </label>
                </div>
            </div>

            <div class="text-right">
                <asp:Button runat="server" id="btnReset" OnClick="btnReset_Click" class="btn" Text="reset" />
                <asp:Button runat="server" id="btnFilter" OnClick="btnFilter_Click" class="btn btn-primary" Text="filter" />
            </div>
        </form>
    </div>
</div>

<% if (SearchResults != null) { %>
    <div class="divider" data-content="results"></div>
    <% if (SearchResults.Count > 0) { %>
        <%@ Import Namespace="MoreLinq" %>
        <% foreach (var batch in SearchResults.Batch(4)) { %>
            <div class="columns">
            <% foreach (var student in batch) { %>
                <a href="/Pages/Student.aspx?id=<%= student.ID %>" class="col-3 tile tile-centered">
                    <div class="tile-icon">
                        <figure class="avatar avatar-md" data-initial="<%= student.Initials %>">
                            <img src="/Content/Avatars/<%= student.Photo %>" onerror="this.style.display='none'">
                        </figure>
                    </div>
                    <div class="tile-content">
                        <p class="tile-title"><%= student.Name %></p>
                    </div>
                </a>
            <% } %>
            </div>
        <% } %>
    <% } else { %>
        <div class="empty">
            <div class="empty-icon">
                <i class="icon icon-people"></i>
            </div>
            <p class="empty-title h5">no students found.</p>
            <p class="empty-subtitle">maybe your criterias are too much.</p>
        </div>
    <% } %>
<% } %>
</asp:Content>