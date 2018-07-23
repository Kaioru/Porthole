<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="UpdateStatus.aspx.cs" Inherits="Porthole.Pages.Controls.Admin.UpdateStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
    <div class="container">
        <form id="fChangeStatus" runat="server">'
            <div class="form-group">
                <div class="col-3 col-sm-12" style="height: 33px" >
                    <strong>
                    <asp:Label class="form-label"  for="input-example-1" ID="lblStatus" runat="server" Text="Status"></asp:Label>
                    </strong>&nbsp;</div>
                <div class="col-9 col-sm-12" >
                    <asp:DropDownList class="form-select" id="ddlStatus" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
        </form>
    </div>
</asp:Content>