<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="ViewSkillset.aspx.cs" Inherits="Porthole.Pages.Controls.Admin.ViewSkillset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
    <div class="container">
    <% foreach (var skill in SkillSets)
        { %>
        <hr />
        <div class="tile">
            <div class="tile-content">
                <p class="tile-title"><%= skill.Name %></p>
            </div>
            <div class="tile-action">
                <a href="UpdateSkillset.aspx" class="btn bg-primary">
                    <i class="icon icon-edit"></i>
                </a>
            </div>
        </div>
        <br />
    
    <%} %>
    <hr />
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