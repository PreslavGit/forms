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
    public partial class FormEditSubject : Form
    {
        private int id;
        private Configurator configurator;
        public FormEditSubject(Configurator configurator)
        {
            InitializeComponent();
            this.configurator = configurator;
        }
        public void Init(int id, string name)
        {
            this.id = id;
            this.name.Text = name;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            this.configurator.Subject.Update(this.id, this.name.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
