<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="Messages.aspx.cs" Inherits="Porthole.Pages.Controls.Parent.Messages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" runat="server">
    <div class="container">
    <form id="form1" runat="server">   
        <div class="form-group">
            <label class="form-label" for="'input-name">Title: </label>
            <asp:Label ID="lblTitle" runat="server"></asp:Label>
        </div>
        <div class="form-group">
            <label class="form-label" for="'input-name">Message: </label>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>

       
    </form>
        </div>
</asp:Content>
