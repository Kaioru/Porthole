<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="Selection.aspx.cs" Inherits="Porthole.Pages.Controls.Parent.Selection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" runat="server">
    <div class="container">
    <form id="form1" runat="server">   
        <div class="form-group">
            <label class="form-label" for="'input-name">Select Mentor: </label>
            <asp:DropDownList ID="ddl_Mentor" runat="server" Width="100px">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <label class="form-label" for="'input-name">Title: </label>
            <asp:TextBox ID="txtTitle" placeholder="Enter title" class="form-input" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="form-label" for="'input-name">Message: </label>
            <asp:TextBox ID="txtMessage" placeholder="Enter message" class="form-input" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Button ID="Button2" runat="server" Text="Send" OnClick="Button2_Click"/>
        </div>
    </form>
        </div>
</asp:Content>
