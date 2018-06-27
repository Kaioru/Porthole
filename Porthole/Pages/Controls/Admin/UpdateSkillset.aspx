<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="UpdateSkillset.aspx.cs" Inherits="Porthole.Pages.Controls.Admin.CreateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
    <div class="container">
        <form id="form1" runat="server">

            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="txtNewSkillName">Name</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:TextBox runat="server" class="form-input" id="txtNewSkillName" placeholder="Name"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="fuLogo">Logo</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:FileUpload ID="fuNewLogo" runat="server" placeholder="New Logo"/>
                </div>
            </div>
            <div class="form-group">
                <div class="col-3 col-sm-12"></div>
                <div class="col-9 col-sm-12">
                    <asp:Button runat="server" id="btnUpdateSkillset" class="btn btn-success" Text="Update"/>
                </div>
            </div>
        </form>
    </div>
</asp:Content>