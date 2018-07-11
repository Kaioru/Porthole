<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="ViewStudent.aspx.cs" Inherits="Porthole.Pages.Controls.Admin.ViewStudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
    
    <div class="container">
        <% foreach (var student in studentList)
            { %>
        <hr />
        <div class="tile">
            <div class="tile-icon">
                <figure class="avatar avatar-md" data-initial="<%= student.Initials %>">
                    <img src="/Content/Avatars/<%= student.Photo %>" onerror="this.style.display='none'">
                </figure>
            </div>
            <div class="tile-content">
                <p class="tile-title"><%= student.Name %></p>
            </div>
            <div class="tile-action">
                <a href="UpdateProfile.aspx?id=<%= student.ID %>" class="btn bg-primary">
                    <i class="icon icon-edit"></i>
                </a>
            </div>
        </div>
        
        <br />
        <%} %>
        <hr />
    </div>
</asp:Content>