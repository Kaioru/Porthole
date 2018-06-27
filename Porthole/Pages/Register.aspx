<%@ Page Language="C#" MasterPageFile="Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Register" CodeBehind="~/Register.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<div class="columns">
    <div class="column col-8">
        <form runat="server" class="form-horizontal">
            <div class="form-group columns">
                <div class="column col-3 col-sm-12">
                    <label class="form-label" for="txName">name</label>
                </div>
                <div class="column col-9 col-sm-12">
                    <asp:TextBox runat="server" class="form-input" id="txtName" placeholder="new number who dis"></asp:TextBox>
                </div>
            </div>
                
            <div class="form-group columns">
                <div class="column col-3 col-sm-12">
                    <label class="form-label" for="txtEmail">email</label>
                </div>
                <div class="column col-9 col-sm-12">
                    <asp:TextBox runat="server" class="form-input" id="txtEmail" placeholder="better not be your 12-year old email"></asp:TextBox>
                </div>
            </div>

            <div class="form-group columns">
                <div class="column col-3 col-sm-12">
                    <label class="form-label" for="txtPassword">password</label>
                </div>
                <div class="column col-9 col-sm-12">
                    <asp:TextBox runat="server" class="form-input" TextMode="Password" id="txtPassword" placeholder="super secret password"></asp:TextBox>
                </div>
            </div>

            <div class="form-group columns">
                <div class="column col-3 col-sm-12">
                    <label class="form-label" for="txtPassword2">repeat password</label>
                </div>
                <div class="column col-9 col-sm-12">
                    <asp:TextBox runat="server" class="form-input" TextMode="Password" id="txtPassword2" placeholder="super secret password (again)"></asp:TextBox>
                </div>
            </div>

            <div class="form-group columns">
                <div class="column col-9 col-sm-12">
                    <asp:Label runat="server" id="lblError" class="text-error" />
                </div>
                <div class="column col-3 col-sm-12">
                    <div class="text-right">
                        <asp:Button runat="server" id="btnRegister" OnClick="btnRegister_Click" class="btn btn-primary" Text="register" />
                    </div>
                </div>
            </div>
        </form>
    </div>
</div>
</asp:Content>