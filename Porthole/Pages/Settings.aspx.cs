﻿using System;
using System.Collections.Generic;
using Porthole.Models;

namespace Porthole.Pages
{
    public partial class Settings : System.Web.UI.Page
    {
        public string AccountType { get; set; }
        public IAccount Account { get; set; }
        public List<SettingsOption> Options { get; set; } = new List<SettingsOption>();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Account = (IAccount)Session["Account"];

            if (Account is Admin)
            {
                this.AccountType = "admin";
                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "create account",
                    Redirect = "Controls/Admin/CreateAccount.aspx"
                });

                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "view student",
                    Redirect = "Controls/Admin/ViewStudent.aspx"
                });

                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "view skillset",
                    Redirect = "Controls/Admin/ViewSkillset.aspx"
                });

                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "view request",
                    Redirect = "Controls/Admin/ViewRequest.aspx"
                });
            }

            if (Account is Models.Student)
            {
                this.AccountType = "student";
                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "update profile",
                    Redirect = "Controls/Student/UpdateProfile.aspx"
                });
                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "update projects",
                    Redirect = "Controls/Student/UpdateProjects.aspx"
                });
                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "view suggestions",
                    Redirect = "Controls/Student/ViewSuggestions.aspx"
                });
            }

            if (Account is Mentor)
            {
                this.AccountType = "mentor";
                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "publicize student",
                    Redirect = "/Pages/Controls/Mentor/PublicizeStudent.aspx"
                });
                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "view suggestions",
                    Redirect = "/Pages/Controls/Mentor/ViewSuggestions.aspx"
                });
                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "view messages",
                    Redirect = "/Pages/Controls/Mentor/ViewMessages.aspx"
                });
                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "search students",
                    Redirect = "/Pages/Controls/Mentor/SearchStudents.aspx"
                });
                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "change password",
                    Redirect = "/Pages/Controls/Mentor/ChangePassword.aspx"
                });
            }


            if (Account is Parent) // Parents are automaatically redirected to the Settings.apsx where they can choose to either RequestAccess to view Portfolio or Send Message to the mentor.
            {
                this.AccountType = "parent";
                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "request child portfolio",
                    Redirect = "Controls/Parent/SendRequest.aspx" // This is for the parents to be redirected to another page to send Rquest to access the portfolio.
                });
                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "send message",
                    Redirect = "Controls/Parent/Selection.aspx" // Send Message (Message Table)
                });
                this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "send reply",
                    Redirect = "Controls/Parent/Reply.aspx" // Send Reply (Reply Table)
                });


            }
        }

        public class SettingsOption
        {
            public string Icon { get; set; }
            public string Option { get; set; }
            public string Redirect { get; set; }
        }
    }
}
