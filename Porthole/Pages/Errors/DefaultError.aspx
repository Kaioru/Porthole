<%@ Page Language="C#" MasterPageFile="~/Pages/Layouts/DefaultTemplate.master" Inherits="Porthole.Pages.Errors.DefaultError" CodeBehind="~/DefaultError.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphContent" Runat="server">
    <div class="columns">
        <div class="column col-8">
            <h1>hey.</h1>
            <p>i bet you were tryna break our app by changing values and stuff.</p>
            <p>don't do that.. please?</p>

            <br />
            <a href="/Pages/Home.aspx">go back to civilization</a>
        </div>
    </div>
</asp:Content>