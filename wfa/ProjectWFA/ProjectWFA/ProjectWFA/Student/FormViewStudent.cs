using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWFA.Student
{
    public partial class FormViewStudent : Form
    {
        private Configurator configurator;
        public FormViewStudent(Configurator configurator)
        {
            InitializeComponent();
            this.configurator = configurator;
        }

        private void FormViewStudent_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = configurator.Student.Load();
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                int fn = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                string specialtyName = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string fName = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string mName = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string lName = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string phone = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string address = this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string email = this.dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

                FormEditStudent formEditSpecialty = new FormEditStudent(this.configurator);
                formEditSpecialty.Init(fn, specialtyName, fName, mName, lName, phone, address, email);
                formEditSpecialty.ShowDialog();
            }
        }
    }
}
