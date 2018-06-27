using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.EntityFrameworkCore;
using Porthole.Models;

namespace Porthole.Pages.Controls.Mentor
{
    public partial class SearchStudents : System.Web.UI.Page
    {
        public bool IsSearch { get; set; } = false;
        public List<Models.Student> SearchResults;
        public Models.Mentor CurrentMentor { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.CurrentMentor = (Models.Mentor)Session["Account"];

            if (!Page.IsPostBack)
            {
                IsSearch = Request.QueryString["search"] != null;
                Reset();

                if (IsSearch)
                {
                    using (var context = new DatabaseContext())
                    {
                        string name = Request.QueryString["name"].ToLower();
                        bool menteeOnly = Request.QueryString["mentee_only"].Equals("True");
                        List<int> skills = Request.QueryString["skills"].Length > 0 ? Request.QueryString["skills"].Split(',').Select(int.Parse).ToList() : new List<int>();

                        var query = context.Student
                                           .Include(s => s.StudentSkillSets)
                                           .ThenInclude(ss => ss.SkillSet)
                                           .Include(s => s.Mentor)
                                           .Where(s => s.Name.ToLower().Contains(name));

                        if (skills.Count > 0) query = query.Where(s => s.StudentSkillSets.Any(ss => skills.Contains(ss.SkillSet.ID)));
                        if (menteeOnly) query = query.Where(s => s.Mentor.ID == CurrentMentor.ID);

                        SearchResults = query.ToList();
                    }
                }
            }
        }

        public void Reset()
        {
            txtName.Text = IsSearch ? Request.QueryString["name"] : string.Empty;
            cbMentees.Checked = IsSearch && Request.QueryString["mentee_only"].Equals("True");

            List<int> skills = IsSearch ? Request.QueryString["skills"].Length > 0 ? Request.QueryString["skills"].Split(',').Select(int.Parse).ToList() : new List<int>() : new List<int>();

            using (var context = new DatabaseContext())
            {
                context.SkillSet.ToList()
                       .ForEach(s => cblSkills.Items.Add(new ListItem
                       {
                           Text = " " + s.Name,
                           Value = s.ID.ToString(),
                           Selected = IsSearch && skills.Contains(s.ID)
                       }));
            }
        }

        public void btnReset_Click(Object sender, EventArgs e)
        {
            Reset();
        }

        public void btnFilter_Click(Object sender, EventArgs e)
        {
            string queries = "";
            List<int> skills = new List<int>();

            foreach (ListItem item in cblSkills.Items)
            {
                if (item.Selected)
                {
                    skills.Add(Convert.ToInt32(item.Value));
                }
            }

            queries += "search=True&";
            queries += "name=" + Server.UrlEncode(txtName.Text) + "&";
            queries += "skills=" + Server.UrlEncode(String.Join(",", skills)) + "&";
            queries += "mentee_only=" + cbMentees.Checked;

            Response.Redirect("/Pages/Controls/Mentor/SearchStudents.aspx?" + queries);
        }
    }
}
