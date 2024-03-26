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
    public partial class FormEditStudent : Form
    {
        private Configurator configurator;
        public FormEditStudent(Configurator configurator)
        {
            InitializeComponent();
            this.configurator = configurator;
        }

        public void Init(int fn, string specialtyName, string firstName, string middleName, string lastName, string phone, string address, string email)
        {
            this.fac_num.Text = fn.ToString();
            this.first_name.Text = firstName;
            this.middle_name.Text = middleName;
            this.last_name.Text = lastName;
            this.phone_2.Text = phone;
            this.address_2.Text = address;
            this.email_2.Text = email;

            var dt = this.configurator.Specialty.Load();
            specialty_cb.DataSource = dt;
            specialty_cb.ValueMember = "id";
            specialty_cb.DisplayMember = "name";

            DataRow currSpecRow = null;
            foreach (var spec in dt.Rows)
            {
                DataRow dr = (DataRow)spec;
                if (dr.ItemArray[1].ToString() == specialtyName)
                {
                    currSpecRow = dr;
                }
            }

            specialty_cb.SelectedIndex = dt.Rows.IndexOf(currSpecRow);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var fn = Int32.Parse(this.fac_num.Text);
            var specId = Int32.Parse(this.specialty_cb.SelectedValue.ToString());
            this.configurator.Student.Update(fn, specId, first_name.Text, middle_name.Text, last_name.Text, phone_2.Text, address_2.Text, email_2.Text);
        }
    }
}
