using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWFA.Subject
{
    public partial class FormViewSubject : Form
    {
        private Configurator Configurator;
        public FormViewSubject(Configurator configurator)
        {
            InitializeComponent();
            Configurator = configurator;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                string name = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                FormEditSubject form = new FormEditSubject(Configurator);
                form.Init(id, name);
                form.ShowDialog();
            }
        }

        private void FormViewSubject_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Configurator.Subject.Load();
            this.dataGridView1.Refresh();
        }
    }
}
