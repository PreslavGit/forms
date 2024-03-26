using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAAS
{
    public partial class StudentInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["username"] == null)
            {
                this.Response.Redirect("Default.aspx");
            }
            if (!IsPostBack)
            {
                if (this.Request["fNumber"] != null)
                {
                    int fNumber = Convert.ToInt32(this.Request["fNumber"]);
                    this.LoadData(fNumber);
                }
                else
                {
                    this.Response.Redirect("Students.aspx");
                }
            }
        }
        private void LoadData(int fNumber)
        {
            Configurator configurator = new Configurator();
            Student student = configurator.LoadStudentById(fNumber);
            TextBoxFNumber.Text = student.FNumber.ToString();
            TextBoxFName.Text = student.FName.ToString();
            TextBoxMName.Text = student.MName.ToString();
            TextBoxLName.Text = student.LName.ToString();
            TextBoxAddress.Text = student.Address.ToString();
            TextBoxPhone.Text = student.Phone.ToString();
            TextBoxEmail.Text = student.Email.ToString();
            TextBoxSpecialtyName.Text = student.SpecialtyName.ToString();

            ViewState["fnumber"] = fNumber.ToString();
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ViewState["fnumber"] != null)
            {
                int id = Convert.ToInt32(this.ViewState["fnumber"]);
                Configurator configurator = new Configurator();
                configurator.UpdateStudent(id, TextBoxFName.Text, TextBoxMName.Text, TextBoxLName.Text, TextBoxAddress.Text, Convert.ToInt32(TextBoxPhone.Text), TextBoxEmail.Text);
                this.Response.Redirect("Students.aspx");
            }

        }
    }
}