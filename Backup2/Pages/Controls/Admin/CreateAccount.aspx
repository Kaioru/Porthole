<%@ Page Language="C#" MasterPageFile="/Pages/Layouts/ControlTemplate.master" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="Porthole.Pages.Controls.Admin.CreateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphForm" Runat="server">
    <div class="container">
        <form class="form-horizontal">
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label">Account type</label>
                </div>
                <div class="col-9 col-sm-12">
                    <label class="form-radio">
                        <input type="radio" name="gender" checked>
                        <i class="form-icon"></i> Student
                    </label>
                    <label class="form-radio">
                        <input type="radio" name="gender">
                        <i class="form-icon"></i> Mentor
                    </label>
                </div>
            </div>
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="input-name">Name</label>
                </div>
                <div class="col-9 col-sm-12">
                    <input class="form-input" type="text" id="input-name" placeholder="Name">
                </div>
            </div>
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="input-example-1">Email</label>
                </div>
                <div class="col-9 col-sm-12">
                    <input class="form-input" type="text" id="input-example-1" placeholder="Email">
                </div>
            </div>
            <div class="form-group">
                <div class="col-3 col-sm-12">
                    <label class="form-label" for="input-example-1">Password</label>
                </div>
                <div class="col-9 col-sm-12">
                    <input class="form-input" type="password" id="input-example-1" placeholder="Password">
                </div>
            </div>
               
            <div class="form-group">
                <div class="col-3 col-sm-12" >
                    <label class="form-label" for="input-example-1">Mentor</label>
                </div>
                <div class="col-9 col-sm-12" >
                    <select class="form-select" id="input-example-1">
                        <option>Choose an option</option>
                        <option>Oon Chee Chian</option>
                        <option>Keith Toh</option>
                        <option>Koh Bok Yan</option>
                    </select>
                </div>
                </div>
            <div class="form-group">
                <div class="col-3 col-sm-12"></div>
                <div class="col-9 col-sm-12">
                    <button class="btn btn-success">Submit</button>
                </div>
            </div>
        </form>        
    </div>
</asp:Content>