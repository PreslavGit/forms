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
    public partial class FormViewGrade : Form
    {
        private Configurator Configurator;
        public FormViewGrade(Configurator configurator)
        {
            InitializeComponent();
            Configurator = configurator;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                int fn = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[3].Value);
                int subjectId = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[4].Value);
                double grade = Convert.ToDouble(this.dataGridView1.SelectedRows[0].Cells[2].Value);

                FormEditGrade formEditSpecialty = new FormEditGrade(Configurator);
                formEditSpecialty.Init(fn, subjectId, grade);
                formEditSpecialty.ShowDialog();
            }
        }

        private void FormViewGrade_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Configurator.Grade.Load();
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Refresh();
        }
    }
}
