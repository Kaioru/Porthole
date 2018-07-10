<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Mentor.PublicizeStudent" CodeBehind="~/PublicizeStudent.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<div class="divider" data-content="mentees"></div>
<form runat="server">
    <asp:CheckBoxList runat="server" id="cblStudents" RepeatDirection="Horizontal" RepeatColumns="4" RepeatLayout="Table" AutoPostBack="true" OnSelectedIndexChanged="cblStudents_SelectedIndexChanged" /> 
</form>
</asp:Content>