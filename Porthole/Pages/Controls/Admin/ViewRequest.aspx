<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="ViewRequest.aspx.cs" Inherits="Porthole.Pages.Controls.Admin.ViewRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
    <div class="container">
    <% foreach (var request in ViewingRequests)
        {%>
        <hr />
        <div class="tile">
            <div class="tile-content">
                <p class="tile-title"><%= viewrequest.Parent.Name %></p>
                <p class="tile-title"><%= viewrequest.StudentName %></p>
            </div>
            <div class="tile-action">
                <a href="UpdateSkillset.aspx?id=<%=viewrequest.Student.ID %>" class="btn bg-primary">
                    <i class="icon icon-edit"></i>
                </a>
            </div>
        </div>
        <br />
    
    </div>
</asp:Content>