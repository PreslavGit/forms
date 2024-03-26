using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWFA
{
    public partial class FormViewSpecialty : Form
    {
        private Configurator configurator;
        public FormViewSpecialty(Configurator config)
        {
            InitializeComponent();
            configurator = config;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                string name = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                FormEditSpecialty formEditSpecialty = new FormEditSpecialty(this.configurator);
                formEditSpecialty.Init(id, name);
                formEditSpecialty.ShowDialog();
            }
        }

        private void FormViewSpecialty_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = configurator.Specialty.Load();
            this.dataGridView1.Refresh();
        }
    }
}
