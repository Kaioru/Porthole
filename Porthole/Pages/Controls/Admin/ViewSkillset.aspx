<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="ViewSkillset.aspx.cs" Inherits="Porthole.Pages.Controls.Admin.ViewSkillset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
    <div class="container">
        <form id="fSearchBar" runat="server">
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="txtSearch">Search</label>
                </div>
               <asp:TextBox runat="server" class="form-input" ID="txtSearch" />
                <p></p>
               <asp:Button runat="server" id="btnSearchBar" class="btn btn-primary float_left" Text="Search" OnClick="btnSearchBar_Click" />
            
            </div>
        </form>
<% if (IsSearch == false) {%>
    <% foreach (var skill in SkillSets)
        { %>
        <div class="divider"></div>
        <div class="tile">
            <div class="tile-content">
                <p class="tile-title"><%= skill.Name %></p>
            </div>
            <div class="tile-action">
                <a href="UpdateSkillset.aspx?id=<%=skill.ID %>" class="btn">
                    <i class="icon icon-edit"></i>
                </a>
            </div>
        </div>
        <br />
    
    <%} %>
    <div class="divider"></div>
   <% } %>
<% if (SearchResults != null) { %>
    <div class="divider" data-content="results"></div>
    <% if (SearchResults.Count > 0) { %>
        <%@ Import Namespace="MoreLinq" %>
        <% foreach (var batch in SearchResults.Batch(4)) { %>
            <% foreach (var skillset in batch) { %>
                
                <div class="tile">
                    <div class="tile-content">
                        <p class="tile-title"><%= skillset.Name %></p>
                    </div>
                    <div class="tile-action">
                        <a href="UpdateSkillset.aspx?id=<%=skillset.ID %>" class="btn">
                            <i class="icon icon-edit"></i>
                        </a>
                    </div>
                </div>
                <div class="divider"></div>
            <% } %>
        <% } %>
    <% } else { %>
        <div class="empty">
            <div class="empty-icon">
                <i class="icon icon-people"></i>
            </div>
            <p class="empty-title h5">No skillsets found</p>
            <p class="empty-subtitle">Check yoself</p>
        </div>
    <% } %>
<% } %>
    <div class="tile">
        <div class="tile-icon">
            <div class="example-tile-icon">
                <i class="icon icon-file centered"></i>
            </div>
            </div>
            <div class="tile-content">
                <p class="tile-title"></p>
            </div>
            <div class="tile-action">
                <a href="CreateSkillset.aspx" class="btn btn-primary">Create</a>
            </div>
        </div>
    </div>
</asp:Content>