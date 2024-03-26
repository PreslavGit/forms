using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWFA
{
    public partial class FormGrade : Form
    {
        private Configurator configurator;
        public FormGrade(Configurator configurator)
        {
            InitializeComponent();
            this.configurator = configurator;
            this.LoadStudents();
            this.LoadSubjects();
        }
        public void LoadStudents()
        {
            var dt = this.configurator.Student.Load();
            student_cb.DisplayMember = "firstname";
            student_cb.ValueMember = "fn";
            student_cb.DataSource = dt;
        }
        public void LoadSubjects()
        {
            var dt = this.configurator.Subject.Load();
            subject_cb.DisplayMember = "name";
            subject_cb.ValueMember = "id";
            subject_cb.DataSource = dt;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var facNum = Int32.Parse((string)student_cb.SelectedValue);
            var subId = Int32.Parse((string)subject_cb.SelectedValue);
            configurator.Grade.Save(facNum, subId, (int)this.final_grade.Value);
        }
    }
}
