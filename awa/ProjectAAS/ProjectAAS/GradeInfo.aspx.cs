using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAAS
{
    public partial class GradeInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["username"] == null)
            {
                this.Response.Redirect("Default.aspx");
            }
            if (!IsPostBack)
            {
                if (this.Request["sId"] != null && this.Request["fNumber"] != null)
                {
                    try
                    {
                        int sId = Convert.ToInt32(this.Request["sId"]);
                        int fNumber = Convert.ToInt32(this.Request["fNumber"]);
                        this.LoadData(sId, fNumber);
                    }
                    catch
                    {
                        this.Response.Redirect("Grades.aspx");
                    }
                }
                else
                {
                    this.Response.Redirect("Grades.aspx");
                }
            }
        }
        private void LoadData(int sId, int fNumber)
        {
            Configurator configurator = new Configurator();
            Grade grade = configurator.LoadGradeById(sId, fNumber);
            this.TextBoxGrade.Text = grade.FinalGrade.ToString();
            this.TextBoxStudent.Text = grade.StudentName;
            this.TextBoxSubject.Text = grade.SubjectName;
            this.ViewState["sId"] = sId.ToString();
            this.ViewState["fNumber"] = fNumber.ToString();
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (this.ViewState["sId"] != null && this.ViewState["fNumber"] != null)
            {
                int sId = Convert.ToInt32(this.ViewState["sId"]);
                int fNumber = Convert.ToInt32(this.ViewState["fNumber"]);
                int grade = Convert.ToInt32(this.TextBoxGrade.Text);

                Configurator configurator = new Configurator();
                configurator.UpdateGrade(sId, fNumber, grade);
                this.Response.Redirect("Grades.aspx");
            }
        }
    }
}