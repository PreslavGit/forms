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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectWFA
{
    public partial class FormStudent : Form
    {
        private Configurator configurator;
        public FormStudent(Configurator configurator)
        {
            InitializeComponent();
            this.configurator = configurator;
            this.LoadSpecialties();
        }

        private void LoadSpecialties()
        {
            var dt = this.configurator.Specialty.Load();
            specialty_cb.DataSource = dt;
            specialty_cb.ValueMember = "id";
            specialty_cb.DisplayMember = "name";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var specId = Int32.Parse((string)specialty_cb.SelectedValue);
            configurator.Student.Save((int)fac_num.Value, specId, first_name.Text, middle_name.Text, last_name.Text, address.Text, phone.Text, email.Text);
        }
    }
}
