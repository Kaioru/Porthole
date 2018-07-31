<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="Porthole.Pages.Controls.Parent.Chat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" runat="server">
    <div class="container">
    <form id="form1" runat="server">
        <div class="form-group">
            <label class="form-label" for="'input-name">Parent </label>
            <asp:TextBox ID="StudName" placeholder="Enter Message" class="form-input" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="Button2" runat="server" Text="Send" OnClick="Button2_Click"/>
        </div>
        
        </form>
        </div>
</asp:Content>
