﻿<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="Porthole.Pages.Controls.Admin.CreateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
    <div class="container">
        <form class="form-horizontal">
                
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="input-name">Profile Picture</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:FileUpload ID="fuLogo" runat="server" placeholder="Logo"/>
                </div>
            </div>

            <div class="form-group">
                <div class="col-3 col-sm-12"></div>
                <div class="col-9 col-sm-12">
                    <asp:Button runat="server" id="btnUpdateProfile" class="btn btn-success" Text="Update" />
                </div>
            </div>
        </form>
    </div>
</asp:Content>