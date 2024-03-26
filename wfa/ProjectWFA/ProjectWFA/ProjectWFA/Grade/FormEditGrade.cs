using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWFA.Grade
{
    public partial class FormEditGrade : Form
    {
        private Configurator configurator;
        private int fn;
        private int subjectId;
        public FormEditGrade(Configurator configurator)
        {
            InitializeComponent();
            this.configurator = configurator;
        }

        public void Init(int fn, int subjectId, double grade)
        {
            this.final_grade.Text = grade.ToString();
            this.subjectId = subjectId;
            this.fn = fn;
        }

        private void FormEditGrade_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var grade = Double.Parse(final_grade.Text);
            this.configurator.Grade.Update(fn, subjectId, grade);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void final_grade_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
