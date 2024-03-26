using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAAS
{
    public partial class Grades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["username"] == null)
            {
                this.Response.Redirect("Default.aspx");
            }
            this.LoadData();
        }
        protected void GridViewContent_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow selectedRow = this.GridViewContent.Rows[index];
                string fNumber = selectedRow.Cells[4].Text;
                string sId = selectedRow.Cells[5].Text;
                this.Response.Redirect("GradeInfo.aspx?sId=" + sId + "&fNumber=" + fNumber);
            }
        }
        private void LoadData()
        {
            Configurator configurator = new Configurator();
            this.GridViewContent.DataSource = configurator.LoadGrades();
            this.GridViewContent.DataBind();
        }
    }
}