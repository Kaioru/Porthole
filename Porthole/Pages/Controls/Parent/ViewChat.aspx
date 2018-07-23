<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="ViewChat.aspx.cs" Inherits="Porthole.Pages.Controls.Parent.ViewChat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" runat="server">
     <p>
        The following message has been sent successfully</p>
    <table cellpadding="0" cellspacing="0" class="w-100">
        <tr>
            <td class="auto-style1">Parent Message :</td>
            <td>
                <asp:Label ID="lblParentmessage" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">DateTime Sent :</td>
            <td>
                <asp:Label ID="lblDateTime" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
