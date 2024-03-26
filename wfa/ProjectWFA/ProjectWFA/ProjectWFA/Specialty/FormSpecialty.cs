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
    public partial class FormSpecialty : Form
    {
        private Configurator config;
        public FormSpecialty(Configurator config)
        {
            InitializeComponent();
            this.config = config;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            this.config.Specialty.Save(this.name.Text);
        }
    }
}
