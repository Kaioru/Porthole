<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="CreateSkillset.aspx.cs" Inherits="Porthole.Pages.Controls.Admin.CreateSkillset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" runat="server">
    <div class="container">
        <form runat="server" class="form-horizontal">
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="txtSkillName">Name</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:TextBox runat="server" class="form-input" id="txtSkillName" placeholder="Name"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-3 col-sm-12"></div>
                <div class="col-9 col-sm-12">
                    <asp:Button runat="server" id="btnCreateSkill" class="btn btn-primary" Text="Create" OnClick="btnCreateSkill_Click"/>
                </div>
            </div>
        </form>
    </div>
</asp:Content>