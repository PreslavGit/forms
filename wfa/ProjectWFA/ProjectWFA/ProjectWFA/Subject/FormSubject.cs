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
    public partial class FormSubject : Form
    {
        private Configurator config;
        public FormSubject(Configurator config)
        {
            InitializeComponent();
            this.config = config;   
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            config.Subject.Save(this.name.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
