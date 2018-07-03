<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="SendRequest.aspx.cs" Inherits="Porthole.Pages.Controls.Parent.SendRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" runat="server">
    <div class="container">
    <form id="form1" runat="server">   
        <div class="form-group">
            <label class="form-label" for="'input-name">Name of Student: </label>
            <asp:TextBox ID="StudName" class="form-input" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Button ID="Button1" runat="server" Text="Send" OnClick="Button1_Click" />
        </div>
    </form>
        </div>
</asp:Content>
