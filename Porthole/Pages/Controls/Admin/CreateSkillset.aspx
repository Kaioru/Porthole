<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="CreateSkillset.aspx.cs" Inherits="Porthole.Pages.Controls.Admin.CreateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
    <div class="container">
            <form class="form-horizontal">

                <div class="form-group">
                    <div class="col-3 col-sm-12">
                        <label class="form-label" for="txtSkillName">Name</label>
                    </div>
                    <div class="col-9 col-sm-12">
                        <asp:TextBox runat="server" class="form-input" id="txtSkillName" placeholder="Name"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-3 col-sm-12">
                        <label class="form-label" for="input-name">Icon</label>
                    </div>
                    <div class="col-9 col-sm-12">
                        <asp:FileUpload ID="fuIcon" runat="server" placeholder="New Icon"/>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-3 col-sm-12"></div>
                    <div class="col-9 col-sm-12">
                        <asp:Button runat="server" id="btnCreateSkill" class="btn btn-success" Text="Create"/>
                    </div>
                </div>
            </form>
        </div>
</asp:Content>