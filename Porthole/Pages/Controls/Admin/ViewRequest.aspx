<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="ViewRequest.aspx.cs" Inherits="Porthole.Pages.Controls.Admin.ViewRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
    <div class="container">
        <form id="fChangeStatus" runat="server">
            <%foreach (var request in ViewRequests)
            {%>
            <hr />
            <div class="tile">
                <div class="tile-content">
                    <p class="tile-title"><%= request.Parent.Name %> Parent of <%= request.StudentName %></p>
                </div>
                <div class="tile-action">
                    <div class="form-group">
                        <div class="col-3 col-sm-12"></div>
                        <div class="col-9 col-sm-12">
                            <asp:Button runat="server" id="btnChangeStatus" class="btn btn-primary icon icon-check" OnClick="btnUpdateSkillset_Click"/>
                            
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <%} %>
        </form>

    </div>
</asp:Content>