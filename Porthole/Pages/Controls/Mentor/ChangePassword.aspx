<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Mentor.ChangePassword" CodeBehind="~/ChangePassword.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<div class="column col-8">
    <form runat="server" class="form-horizontal">
        <div class="form-group">
            <div class="col-3 col-sm-12">
                <label class="form-label" for="txtPassword">current password</label>
            </div>
            <div class="col-9 col-sm-12">
                <asp:TextBox runat="server" class="form-input" TextMode="Password" id="txtPassword" placeholder="current password"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div class="col-3 col-sm-12">
                <label class="form-label" for="txtNewPassword">new password</label>
            </div>
            <div class="col-9 col-sm-12">
                <asp:TextBox runat="server" class="form-input" TextMode="Password" id="txtNewPassword" placeholder="new password"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div class="col-3 col-sm-12">
                <label class="form-label" for="txtNewPassword2">retype password</label>
            </div>
            <div class="col-9 col-sm-12">
                <asp:TextBox runat="server" class="form-input" TextMode="Password" id="txtNewPassword2" placeholder="retype new password"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <asp:RequiredFieldValidator runat="server" 
                ControlToValidate="txtPassword"
                ErrorMessage="password is required">&nbsp;
            </asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator runat="server" 
                ControlToValidate="txtNewPassword"
                ErrorMessage="new password is required">&nbsp;
            </asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator runat="server" 
                ControlToValidate="txtNewPassword2"
                ErrorMessage="repeat password is required">&nbsp;
            </asp:RequiredFieldValidator>
            <!-- TODO: Fix this -->
            <asp:CompareValidator
                    ControlToValidate="txtNewPassword2"
                    ControlToCompare="txtNewPassword"
                    Operator="Equal"
                    ErrorMessage="new passwords do not match">&nbsp;
            </asp:CompareValidator>
            <asp:ValidationSummary runat="server" />
        </div>

        <div class="text-right">
            <button class="btn">reset</button>
            <asp:Button runat="server" id="btnSubmit" OnClick="btnSubmit_Click" class="btn btn-primary" Text="submit" />
        </div>
    </form>
</div>
</asp:Content>