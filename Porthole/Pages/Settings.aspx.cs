using System;
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

			if (Account is Models.Student) {
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
                    Redirect = ""
                });
				this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "view suggestions",
                    Redirect = ""
                });
			}

			if (Account is Mentor) {
				this.AccountType = "mentor";
				this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "publicize portfolios",
                    Redirect = ""
                });
				this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "view suggestions",
                    Redirect = ""
                });
				this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "view mentees",
                    Redirect = ""
                });
				this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "search students",
                    Redirect = ""
                });
				this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "change password",
                    Redirect = ""
                });
			}

			if (Account is Parent) {
				this.AccountType = "parent";
				this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "request child portfolio",
                    Redirect = ""
                });
				this.Options.Add(new SettingsOption
                {
                    Icon = "",
                    Option = "view messages",
                    Redirect = ""
                });
			}
		}

		public class SettingsOption {
			public string Icon { get; set; }
			public string Option { get; set; }
			public string Redirect { get; set; }
		}
    }
}
