<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Student.CreateProject" CodeBehind="~/CreateProject.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
<div class="tile tile-centered">
    <div class="tile-icon">
        <figure runat="server" id="figPoster" class="avatar avatar-main" alt="avatar"></figure>
    </div>
    <div class="tile-content">
        <h1><asp:Literal ID="lTitle" runat="server"></asp:Literal></h1>
    </div>
</div>

<div class="columns">
    <div class="column col-8">
        <form runat="server" class="form-horizontal">
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="txtTitle">title</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:TextBox runat="server" class="form-input" AutoPostBack="true" OnTextChanged="txtTitle_TextChanged" id="txtTitle"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="txtDescription">description</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:TextBox runat="server" class="form-input" id="txtDescription" placeholder="tell us a lil' bit about the project" TextMode="MultiLine" Rows="8"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="txtURL">url</label>
                </div>
                <div class="col-9 col-sm-12">
                    <div class="input-group">
                        <span class="input-group-addon">
                            <i class="icon icon-link"></i>
                        </span>
                        <asp:TextBox runat="server" class="form-input" id="txtURL" placeholder="webpage"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="fuPoster">poster</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:FileUpload id="fuPoster" runat="server" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="txtReflections">reflections</label>
                </div>
                <div class="col-9 col-sm-12">
                    <asp:TextBox runat="server" class="form-input" id="txtReflections"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="input-skills">collaborators</label>
                </div>
                <div class="col-9 col-sm-12">
                    <div class="chip">
                        <img src="/Content/Avatars/<%= CurrentStudent.Photo %>" class="avatar avatar-sm"> <%= CurrentStudent.Name %>
                    </div>
                    <br />
                    <small class="text-gray">you add collaborators after creating the project.</small>
                </div>
            </div>

            <div class="form-group">
                <asp:RequiredFieldValidator runat="server" 
                    ControlToValidate="txtTitle"
                    ErrorMessage="title is required">&nbsp;
                </asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator runat="server" 
                    ControlToValidate="txtDescription"
                    ErrorMessage="description is required">&nbsp;
                </asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator runat="server" 
                    ControlToValidate="txtURL"
                    ErrorMessage="url is required">&nbsp;
                </asp:RequiredFieldValidator>
                <asp:RequiredFieldValidator runat="server" 
                    ControlToValidate="txtReflections"
                    ErrorMessage="reflections is required">&nbsp;
                </asp:RequiredFieldValidator>
                <asp:ValidationSummary runat="server" />
            </div>

            <div class="text-right">
                <asp:Button runat="server" id="btnReset" OnClick="btnReset_Click" class="btn" Text="reset" />
                <asp:Button runat="server" id="btnSubmit" OnClick="btnSubmit_Click" class="btn btn-primary" Text="submit" />
            </div>
        </form>
    </div>
</div>
</asp:Content>