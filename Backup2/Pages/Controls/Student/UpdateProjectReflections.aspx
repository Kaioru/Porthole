<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Student.UpdateProjectReflections" CodeBehind="~/UpdateProjectReflections.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<div class="tile tile-centered">
    <figure class="avatar avatar-main" data-initial="<%= CurrentProject.Initials %>">
        <img src="/Content/Posters/<%= CurrentProject.Poster %>" onerror="this.style.display='none'">
    </figure>
    <div class="tile-content">
        <h1><%= CurrentProject.Title %></h1>
        <p class="tile-subtitle text-gray"><%= CurrentProject.ShortDescription %></p>
    </div>
</div>

<div class="columns">
    <div class="column col-8">
        <form runat="server" class="form-horizontal">
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="txtReflections">reflections</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:TextBox runat="server" class="form-input" id="txtReflections"></asp:TextBox>
                </div>
            </div>
                
            <div class="form-group columns">
                <div class="column col-9 col-sm-12">
                    <asp:Label runat="server" id="lblInfo" />
                </div>
                <div class="column col-3 col-sm-12">
                    <div class="text-right">
                        <asp:Button runat="server" id="btnReset" OnClick="btnReset_Click" class="btn" Text="reset" />
                        <asp:Button runat="server" id="btnSubmit" OnClick="btnSubmit_Click" class="btn btn-primary" Text="submit" />
                    </div>
                </div>
            </div>
        </form>
    </div>
</div>
</asp:Content>