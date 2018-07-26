<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="ViewRequest.aspx.cs" Inherits="Porthole.Pages.Controls.Admin.ViewRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
    <div class="container">
        <%if (ViewingRequests.Count > 0)
            {%>
            <%foreach (var request in ViewingRequests)
                {%>
            <hr />
            <div class="tile">
                <div class="tile-content">
                    <p class="tile-title"><%= request.StudentName %> </p>
                    <p class="tile-subtitle">child of <%= request.Parent.Name %></p>
                </div>
                <div class="tile-action">             
                    <a href="ViewRequest.aspx?id=<%= request.ID %>&check=true" class="btn">
                    <i class="icon icon-check"></i>
                    </a>
                    <a href="ViewRequest.aspx?id=<%= request.ID %>&cross=true" class="btn">
                    <i class="icon icon-cross"></i>
                    </a>
                </div>
            </div>
            <br />
            <%} %>
        <%} %>
        <%else
            {%>
        <div class="tile">
            <div class="tile-content">
                <p class="tile-title">There is no record</p>
            </div>
        </div>
        <%} %>
    </div>
</asp:Content>