﻿<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" Inherits="Porthole.Pages.Controls.Student.UpdateProject" CodeBehind="~/UpdateProject.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphTitle" Runat="server">
    <h1>edit project</h1>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphForm" Runat="server">
<div class="tile tile-centered">
    <div class="tile-icon">
        <img src="" class="avatar avatar-main" alt="avatar">
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
                    <asp:TextBox runat="server" class="form-input" placeholder="a great name for a great project" AutoPostBack="true" OnTextChanged="txtTitle_TextChanged" id="txtTitle"></asp:TextBox>
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
                    <asp:CheckBoxList runat="server" id="cblCollaborators" RepeatDirection="Horizontal" RepeatColumns="3" RepeatLayout="Table" />
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