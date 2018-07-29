<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="Reply.aspx.cs" Inherits="Porthole.Pages.Controls.Parent.Reply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" runat="server">
    <div class="container">
        <form id="form1" runat="server">
            <div class="form-group">
                <label class="form-label" for="'input-name">Select Message: </label>
            <asp:DropDownList ID="ddl_Message" runat="server" Width="100px">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            </div>
            <div class="form-group">
            <label class="form-label" for="'input-name">Select Mentor: </label>
            <asp:DropDownList ID="ddl_Mentor" runat="server" Width="100px">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </div>
            <div class="form-group">
            <label class="form-label" for="'input-name">Reply:</label>
            <asp:TextBox ID="txtReply" placeholder="Enter reply" class="form-input" runat="server"></asp:TextBox>
        </div>

            <div class="form-group">
                <asp:Button ID="Button3" runat="server" Text="Send" OnClick="Button3_Click" />
            </div>
        </form>
    </div>
</asp:Content>
