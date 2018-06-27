<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Mentor.PublicizeStudent" CodeBehind="~/PublicizeStudent.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<div class="container">
    <div class="toast toast-success">
        <button class="btn btn-clear float-right"></button>
        publicised keifsu's portfolio!
    </div>
    <div class="toast toast-warning">
        <button class="btn btn-clear float-right"></button>
        unpublicised keifsu's portfolio.
    </div>
</div>

<div class="container">
    <div class="divider" data-content="mentees"></div>
    <div class="columns">
        <div class="column col-4 tile tile-centered">
            <div class="tile-icon">
                <figure class="avatar avatar-md">
                    <img src="https://avatars3.githubusercontent.com/u/6829787?s=420&v=4" />
                </figure>
            </div>
            <div class="tile-content">
                <p class="tile-title">keifsu</p>
            </div>
            <div class="tile-action">
                <label class="form-switch">
                    <input type="checkbox">
                    <i class="form-icon"></i>
                </label>
            </div>
        </div>
        <div class="column col-4 tile tile-centered">
            <div class="tile-icon">
                <figure class="avatar avatar-md">
                    <img src="http://steamavatars.co/?media_dl=2072" />
                </figure>
            </div>
            <div class="tile-content">
                <p class="tile-title">Chitoge</p>
            </div>
            <div class="tile-action">
                <label class="form-switch">
                    <input type="checkbox">
                    <i class="form-icon"></i>
                </label>
            </div>
        </div>
        <div class="column col-4 tile tile-centered">
            <div class="tile-icon">
                <figure class="avatar avatar-md">
                    <img src="https://i.pinimg.com/originals/8a/01/3d/8a013d0a9c4d835e71071c6b8bc94ed4.jpg" />
                </figure>
            </div>
            <div class="tile-content">
                <p class="tile-title">Seto</p>
            </div>
            <div class="tile-action">
                <label class="form-switch">
                    <input type="checkbox">
                    <i class="form-icon"></i>
                </label>
            </div>
        </div>
    </div>
</div>
</asp:Content>