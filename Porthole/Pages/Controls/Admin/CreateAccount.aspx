<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="Porthole.Pages.Controls.Admin.CreateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
    <div class="container">
        <form id="fCreateAcc" runat="server">
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label">Account type</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:RadioButtonList ID="rblAccountType" runat="server" OnSelectedIndexChanged="rblAccountType_SelectedIndexChanged" RepeatDirection="Horizontal"></asp:RadioButtonList>
                    <asp:RequiredFieldValidator runat="server" 
                        ControlToValidate="rblAccountType"
                        ErrorMessage="Specify account type">&nbsp;
                    </asp:RequiredFieldValidator>
                    <br />
                </div>
            </div>
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="txtName">Name</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:TextBox runat="server" class="form-input" id="txtName" placeholder="Name"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" 
                        ControlToValidate="txtName"
                        ErrorMessage="Name is required">&nbsp;
                    </asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="input-example-1">Email</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:TextBox runat="server" class="form-input" id="txtEmail" placeholder="Email"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" 
                        ControlToValidate="txtEmail"
                        ErrorMessage="Email is required">&nbsp;
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="Please enter valid email" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="input-example-1">Password</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:TextBox runat="server" class="form-input" TextMode="Password" id="txtPassword" placeholder="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" 
                        ControlToValidate="txtPassword"
                        ErrorMessage="Password is required">&nbsp;
                    </asp:RequiredFieldValidator>
                </div>
            </div>
               
            <div class="form-group">
                <div class="col-3 col-sm-12" style="height: 33px" >
                    <strong>
                    <asp:Label class="form-label"  for="input-example-1" ID="lblMentor" runat="server" Text="Mentor"></asp:Label>
                    </strong>&nbsp;</div>
                <div class="col-9 col-sm-12" >
                    <asp:DropDownList class="form-select" id="ddlMentor" runat="server">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator runat="server" 
                        ControlToValidate="ddlMentor"
                        ErrorMessage="Mentor is required">&nbsp;
                    </asp:RequiredFieldValidator>
                </div>
                </div>
            <div class="form-group">
                <div class="col-3 col-sm-12"></div>
                <div class="col-9 col-sm-12">
                    <asp:Button runat="server" id="btnCreate" class="btn btn-primary" Text="Create" OnClick="btnCreate_Click" />
                </div>
            </div>
            <div class="form-group">
                <asp:ValidationSummary runat="server" />
            </div>
        </form>
    </div>
</asp:Content>